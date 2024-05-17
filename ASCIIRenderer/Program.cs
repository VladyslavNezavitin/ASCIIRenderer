using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

using UltraShit.Console;
using Serialization;

class Program
{
    private static ASCIIRenderer renderer;

    [STAThread]
    private static void Main()
    {
        RendererSettings s = new RendererSettings();
        renderer = new ASCIIRenderer(s);

        PerformConsoleSetup(s.WindowWidth, s.WindowHeight, s.FontWidth, s.FontHeight);

        renderer.FrameRendered += Renderer_OnFrameRendered;
        renderer.SequenceRendered += Renderer_OnSequenceRendered;
        renderer.Settings.ResolutionChanged += Renderer_OnResolutionChanged;


        using (RendererSetupForm form = new RendererSetupForm(renderer))
        {
            form.RenderButtonPressed += Form_OnRenderButtonPressed;
            form.PreviewButtonPressed += Form_OnPreviewButtonPressed;

            Application.Run(form);

            form.RenderButtonPressed -= Form_OnRenderButtonPressed;
            form.PreviewButtonPressed -= Form_OnPreviewButtonPressed;
        }

        renderer.FrameRendered -= Renderer_OnFrameRendered;
        renderer.SequenceRendered -= Renderer_OnSequenceRendered;
        renderer.Settings.ResolutionChanged -= Renderer_OnResolutionChanged;
    }

    public static void Renderer_OnResolutionChanged(int width, int height, int fontWidth, int fontHeight)
    {
        PerformConsoleSetup(width, height, fontWidth, fontHeight);
    }

    private static void Form_OnPreviewButtonPressed()
    {
        Console.Clear();
        renderer.RenderAsync(true);
    }


    static string outputFile1;
    private static void Form_OnRenderButtonPressed(string outputFile)
    {
        Console.Clear();
        renderer.RenderAsync();
        outputFile1 = outputFile;
    }

    private static void Renderer_OnSequenceRendered(RenderData data)
    {
        using (FileStream stream = File.Create(outputFile1))
        {
            data.SerializeAndCompress(stream);
        }
    }

    public static void Renderer_OnFrameRendered(FrameData data)
    {
        Display(data);
    }



    public static void DisplaySequence(RenderData data)
    {
        int delay = 1000 / data.fps;

        while (data.loop)
            foreach (var frame in data.frames)
            {
                Display(frame);
                Thread.Sleep(delay);
            }
    }

    private static void Display(FrameData frame)
    {
        string output = new string(frame.asciiData);
        ushort[] attributes = frame.attributes;

        ConsoleShit.FillConsoleBuffer(output);
        ConsoleShit.FillConsoleAttributeBuffer(attributes);

        Console.SetCursorPosition(0, 0);
    }

    private static void PerformConsoleSetup(int width, int height, int fontWidth, int fontHeight)
    {
        ConsoleShit.SetConsoleFont((short)fontWidth, (short)fontHeight);
        Console.SetWindowSize(width, height);
        Console.SetBufferSize(width, height);
        Console.SetWindowSize(width, height);

        Console.CursorVisible = false;
    }
}