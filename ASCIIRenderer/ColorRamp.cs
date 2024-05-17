using System.Drawing;
using System;

internal class ColorRamp
{
    public struct Step
    {
        public ConsoleColor color;
        public byte threshold;
    }

    private Step[] steps;

    public ColorRamp(Step[] steps)
    {
        this.steps = steps;
    }

    public static ColorRamp Bluescale =>
        new ColorRamp(new Step[]
            {
                new Step()
                {
                    color = ConsoleColor.Black,
                    threshold = 50
                },
                new Step()
                {
                    color = ConsoleColor.DarkBlue,
                    threshold = 100
                },
                new Step()
                {
                    color = ConsoleColor.DarkCyan,
                    threshold = 150
                },
                new Step()
                {
                    color = ConsoleColor.Blue,
                    threshold = 200
                },
                new Step()
                {
                    color = ConsoleColor.Cyan,
                    threshold = 250
                },
            });

    public static ColorRamp Grayscale =>
        new ColorRamp(new Step[]
            {
                    new Step()
                    {
                        color = ConsoleColor.Black,
                        threshold = 64
                    },
                    new Step()
                    {
                        color = ConsoleColor.DarkGray,
                        threshold = 128
                    },
                    new Step()
                    {
                        color = ConsoleColor.Gray,
                        threshold = 192
                    },
                    new Step()
                    {
                        color = ConsoleColor.White,
                        threshold = 255
                    }
            });

    public static ColorRamp Redscale =>
    new ColorRamp(new Step[]
        {
                new Step()
                {
                    color = ConsoleColor.Black,
                    threshold = 37
                },
                new Step()
                {
                    color = ConsoleColor.DarkRed,
                    threshold = 74
                },
                new Step()
                {
                    color = ConsoleColor.DarkMagenta,
                    threshold = 111
                },
                new Step()
                {
                    color = ConsoleColor.DarkYellow,
                    threshold = 148
                },
                new Step()
                {
                    color = ConsoleColor.Red,
                    threshold = 185
                },
                new Step()
                {
                    color = ConsoleColor.Magenta,
                    threshold = 222
                },
                new Step()
                {
                    color = ConsoleColor.Yellow,
                    threshold = 255
                }
        });

    public static ColorRamp Hope =>
        new ColorRamp(new Step[]
            {
                new Step()
                {
                    color = ConsoleColor.Cyan,
                    threshold = 85
                },
                new Step()
                {
                    color = ConsoleColor.Red,
                    threshold = 170
                },
                new Step()
                {
                    color = ConsoleColor.Yellow,
                    threshold = 255
                }
            });

    public static ConsoleColor GetMappedColor(ColorRamp colorRamp, Color color)
    {
        foreach (var step in colorRamp.steps)
        {
            if (color.R <= step.threshold)
                return step.color;
        }

        return colorRamp.steps[colorRamp.steps.GetUpperBound(0)].color;
    }

    

    
}