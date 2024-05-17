using System;
using System.Drawing;

internal static class ColorExtensions
{
    public static void ApplyContrastModifier(this ref Color color, double contrast)
    {
        byte newR = ApplyContrast(color.R, contrast);
        byte newG = ApplyContrast(color.G, contrast);
        byte newB = ApplyContrast(color.B, contrast);

        color = Color.FromArgb(1, newR, newG, newB);
    }

    public static void ApplyHSLModifier(this ref Color color, int h, double s, double l)
    {
        RGBToHSL(color.R, color.G, color.B, out int H, out double S, out double L);

        H = Clamp(H + h, 0, 360);
        S = Clamp01(S + s);
        L = Clamp01(L + l);

        HSLToRGB(H, S, L, out byte r, out byte g, out byte b);
        color = Color.FromArgb(255, r, g, b);
    }

    public static void ApplyRGBModifier(this ref Color color, int r, int g, int b)
    {
        int R = Clamp(color.R + r, 0, 255);
        int G = Clamp(color.G + g, 0, 255);
        int B = Clamp(color.B + b, 0, 255);

        color = Color.FromArgb(255, R, G, B);
    }

    public static void Quantize(this ref Color color, int levels)
    {
        if (levels <= 0) return;

        byte newR = Quantize(color.R, levels);
        byte newG = Quantize(color.G, levels);
        byte newB = Quantize(color.B, levels);

        color = Color.FromArgb(1, newR, newG, newB);
    }

    public static void Desaturate(this ref Color color)
    {
        byte value = (byte)((color.R + color.G + color.B) / 3);
        color = Color.FromArgb(1, value, value, value);
    }

    public static ConsoleColor GetClosestConsoleColor(this Color color)
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



    private static void RGBToHSL(byte r, byte g, byte b, out int h, out double s, out double l)
    {           
        double R = r / 255.0;
        double G = g / 255.0;
        double B = b / 255.0;
        double H = 0;

        double vmax = Math.Max(Math.Max(R, G), B), vmin = Math.Min(Math.Min(R, G), B);
        l = (vmax + vmin) / 2;

        if (Math.Abs(vmax - vmin) < Double.Epsilon)
        {
            H = s = 0; // achromatic
        }
        else
        {
            double d = vmax - vmin;
            s = l > 0.5 ? d / (2 - vmax - vmin) : d / (vmax + vmin);
            if (Math.Abs(vmax - R) < Double.Epsilon)
                H = (G - B) / d + (G < B ? 6 : 0);
            if (Math.Abs(vmax - G) < Double.Epsilon)
                H = (B - R) / d + 2;
            if (Math.Abs(vmax - B) < Double.Epsilon)
                H = (R - G) / d + 4;
            H /= 6;
        }

        h = (int)(H * 360);
    }

    private static void HSLToRGB(int h, double s, double l, out byte r, out byte g, out byte b)
    {
        double H = h / 360.0;
        double rD, gD, bD;

        if (Math.Abs(s) < Double.Epsilon)
        {
            rD = gD = bD = l; // achromatic
        }
        else
        {
            double q = l < 0.5 ? l * (1 + s) : l + s - l * s;
            double p = 2 * l - q;
            rD = HueToRgb(p, q, H + 1.0 / 3);
            gD = HueToRgb(p, q, H);
            bD = HueToRgb(p, q, H - 1.0 / 3);
        }

        r = (byte)Math.Round(rD * 255);
        g = (byte)Math.Round(gD * 255);
        b = (byte)Math.Round(bD * 255);

        double HueToRgb(double p, double q, double t)
        {
            if (t < 0) t += 1;
            if (t > 1) t -= 1;
            if (t < 1.0 / 6) return p + (q - p) * 6 * t;
            if (t < 1.0 / 2) return q;
            if (t < 2.0 / 3) return p + (q - p) * (2.0 / 3 - t) * 6;
            return p;
        }
    }  

    private static byte ApplyContrast(int value, double contrast)
    {
        value = (int)(contrast * (value - 128) + 128);
        value = Clamp(value, 0, 255);

        return (byte)value;
    }

    private static byte Quantize(byte value, int levels)
    {
        if (levels <= 0)
            return value;

        int step = 256 / levels;
        int quantizedValue = (value / step) * step;
        return (byte)Math.Min(quantizedValue + step / 2, 255);
    }

    private static double Clamp01(double value)
    {
        if (value > 1.0) value = 1.0;
        if (value < 0.0) value = 0.0;

        return value;
    }

    private static int Clamp(int value, int min, int max)
    {
        if (value > max) value = max;
        if (value < min) value = min;

        return value;
    }
}