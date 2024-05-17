using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Serialization;

internal class ASCIIRenderer
{
    public event Action<RenderData> SequenceRendered;
    public event Action<FrameData> FrameRendered;
    public event Action<float> ProgressTick;

    private static char[] asciiTableFull = "@$B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\\|()1{}[]?-_+~<>i!lI;:,\"^`'. ".Reverse().ToArray();
    private static char[] asciiTableShort = " .:-=+*#%@".ToCharArray();

    public RendererSettings Settings { get; private set; }
    private CancellationTokenSource renderCTSource;

    public ASCIIRenderer(RendererSettings settings)
    {
        Settings = settings;
    }

    public async void RenderAsync(bool preview = false)
    {
        renderCTSource?.Cancel();
        renderCTSource = new CancellationTokenSource();

        RenderData? renderData = await Task.Run(() => Render(renderCTSource.Token, preview));

        if (renderData != null)
            SequenceRendered?.Invoke((RenderData)renderData);
    }

    private RenderData? Render(CancellationToken token, bool preview)
    {
        Bitmap bitmap = new Bitmap(Settings.filePath);
        FrameDimension dimension = new FrameDimension(bitmap.FrameDimensionsList[0]);
        
        int frameCount = Settings.renderSingleFrame ? 1 : bitmap.GetFrameCount(dimension);
        FrameData[] renderedFrames = new FrameData[frameCount];

    loop:
        for (int i = 0; i < frameCount; i++)
        {
            if (token.IsCancellationRequested)
                return null;

            int frameIndex = Settings.renderSingleFrame ? Settings.frame : i;
            bitmap.SelectActiveFrame(dimension, frameIndex);
            Bitmap frame = new Bitmap(bitmap);
            frame = ResizeBitmap(frame);

            renderedFrames[i] = RenderFrame(frame);

            bool isLast = i == frameCount - 1;
            float progress = isLast ? 100 : (float)i / frameCount;

            FrameRendered?.Invoke(renderedFrames[i]);
            ProgressTick?.Invoke(progress);
        }
        if (preview) goto loop;

        RenderData renderData = new RenderData()
        {
            frames = renderedFrames,
            loop = Settings.loop,
            fps = Settings.fps
        };

        return renderData;
    }

    public static int GetFrameCount(string filePath)
    {
        Bitmap bitmap = new Bitmap(filePath);
        FrameDimension dimension = new FrameDimension(bitmap.FrameDimensionsList[0]);
        int count = bitmap.GetFrameCount(dimension);

        return count;
    }

    private FrameData RenderFrame(Bitmap bitmap)
    {
        ushort[] attributes = new ushort[bitmap.Width * bitmap.Height];
        char[] asciiData = Settings.renderMode == RenderMode.ASCIIArt ?
            new char[bitmap.Width * bitmap.Height] : null;

        FrameData data = new FrameData()
        {
            asciiData = asciiData,
            attributes = attributes
        };

        for (int y = 0; y < bitmap.Height; y++)
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                Color pixel = bitmap.GetPixel(x, y);
                
                data.attributes[y * bitmap.Width + x] = GetAttributesFromColor(pixel);

                if (data.asciiData != null)
                    data.asciiData[y * bitmap.Width + x] = GetCharFromColor(pixel);
            }
        }

        return data;
    }

    private char GetCharFromColor(Color color)
    {
        color.Desaturate();
        ApplyModifierStackToColor(ref color);

        char[] asciiTable;
        switch (Settings.asciiTable)
        {
            case ASCIITable.Full: asciiTable = asciiTableFull; break;
            default: asciiTable = asciiTableShort; break;
        }

        int charIndex = (int)Math.Ceiling((double)color.R / 255 * asciiTable.GetUpperBound(0));
        
        return asciiTable[charIndex];
    }

    private ushort GetAttributesFromColor(Color color)
    {
        ConsoleColor bgColor, charColor;
        ushort attributes;

        if (Settings.renderMode == RenderMode.ASCIIArt)
        {
            charColor = GetConsoleColor(color);
            bgColor = Settings.asciiModeBGColor;

            attributes = (ushort)((ConsoleColor)((int)bgColor << 4) | charColor);
        }
        else
        {
            bgColor = GetConsoleColor(color);
            attributes = (ushort)(ConsoleColor)((int)bgColor << 4);
        }

        return attributes;
    }

    private ConsoleColor GetConsoleColor(Color color)
    {
        if (Settings.colorMode == ColorMode.Solid &&
            Settings.renderMode == RenderMode.ASCIIArt)
        {
            return Settings.solidModeColor;
        }

        if (Settings.colorMode == ColorMode.Color)
        {
            ApplyModifierStackToColor(ref color);
            return GetClosestConsoleColor(color);
        }

        color.Desaturate();
        ApplyModifierStackToColor(ref color);

        ColorRamp colorRamp;

        switch (Settings.colorMode)
        {
            case ColorMode.Bluescale: colorRamp = ColorRamp.Bluescale; break;
            case ColorMode.Redscale: colorRamp = ColorRamp.Redscale; break;
            case ColorMode.Hope: colorRamp = ColorRamp.Hope; break;
            default: colorRamp = ColorRamp.Grayscale; break;
        }

        return ColorRamp.GetMappedColor(colorRamp, color);
    }

    public static ConsoleColor GetClosestConsoleColor(Color color)
    {
        ConsoleColor ret = 0;
        double rr = color.R, gg = color.G, bb = color.B, delta = double.MaxValue;

        foreach (ConsoleColor cc in Enum.GetValues(typeof(ConsoleColor)))
        {
            var n = Enum.GetName(typeof(ConsoleColor), cc);
            var c = Color.FromName(n == "DarkYellow" ? "Orange" : n); // bug fix
            var t = Math.Pow(c.R - rr, 2.0) + Math.Pow(c.G - gg, 2.0) + Math.Pow(c.B - bb, 2.0);
            if (t == 0.0)
                return cc;
            if (t < delta)
            {
                delta = t;
                ret = cc;
            }
        }
        return ret;
    }

    private void ApplyModifierStackToColor(ref Color c)
    {
        c.ApplyContrastModifier(Settings.contrast);
        c.Quantize(Settings.quantization);
        c.ApplyHSLModifier(Settings.hue, Settings.saturation, Settings.lightness);
        c.ApplyRGBModifier(Settings.valueR, Settings.valueG, Settings.valueB);
    }

    private Bitmap ResizeBitmap(Bitmap bitmap)
    {
        return new Bitmap(bitmap, Settings.WindowWidth, Settings.WindowHeight);
    }


}