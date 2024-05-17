using System.IO;
using System;

public class RendererSettings
{
    public event Action<int, int, int, int> ResolutionChanged;

    private int windowWidth = 64, windowHeight = 64;
    private int fontWidth = 4, fontHeight = 4;

    public int WindowWidth { get => windowWidth; set { windowWidth = value; OnResolutionChanged(); } }
    public int WindowHeight { get => windowHeight; set { windowHeight = value; OnResolutionChanged(); } }
    public int FontWidth { get => fontWidth; set { fontWidth = value; OnResolutionChanged(); } }
    public int FontHeight { get => fontHeight; set { fontHeight = value; OnResolutionChanged(); } }

    public RenderMode renderMode;
    public ColorMode colorMode;
    public ConsoleColor solidModeColor;
    public ConsoleColor asciiModeBGColor;
    public ASCIITable asciiTable;

    public double contrast;
    public int hue;
    public double saturation;
    public double lightness;
    public int quantization;
    public int valueR;
    public int valueG;
    public int valueB;

    public string filePath;
    public bool renderSingleFrame;
    public int frame;
    public int fps;
    public bool loop;

    public bool IsMultiframeFile()
    {
        return File.Exists(filePath) &&
            Path.GetExtension(filePath).ToLower() == ".gif";
    }

    private void OnResolutionChanged()
    {
        ResolutionChanged?.Invoke(windowWidth, windowHeight, fontWidth, fontHeight);
    }
}