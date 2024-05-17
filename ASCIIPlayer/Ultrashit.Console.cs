using System.Runtime.InteropServices;
using System;
using System.Drawing;

namespace UltraShit.Console
{
    public static class ConsoleShit
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetCurrentConsoleFontEx(IntPtr consoleOutput, bool maximumWindow, ref CONSOLE_FONT_INFO_EX consoleFontInfo);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteConsoleOutputAttribute(IntPtr hConsoleOutput, ushort[] lpAttribute, uint nLength, COORD dwWriteCoord, out uint lpNumberOfAttrsWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteConsoleOutputCharacter(IntPtr hConsoleOutput, string lpCharacter, uint nLength, COORD dwWriteCoord, out uint lpNumberOfCharsWritten);

        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);




        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct CONSOLE_FONT_INFO_EX
        {
            public int cbSize;
            public int nFont;
            public COORD dwFontSize;
            public int FontFamily;
            public int FontWeight;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string FaceName;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SMALL_RECT
        {
            public short Left;
            public short Top;
            public short Right;
            public short Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct COORD
        {
            public short X;
            public short Y;
        }

        public const int SW_MAXIMIZE = 3;
        public const int MF_BYCOMMAND = 0x00000000;
        public const int SC_CLOSE = 0xF060;
        public const int SC_MINIMIZE = 0xF020;
        public const int SC_MAXIMIZE = 0xF030;
        public const int SC_SIZE = 0xF000;



        public static void SetConsoleFont(short xSize, short ySize, string name = "Consolas")
        {
            IntPtr hConsole = GetStdHandle(-11);

            CONSOLE_FONT_INFO_EX fontInfo = new CONSOLE_FONT_INFO_EX();
            fontInfo.cbSize = Marshal.SizeOf(fontInfo);
            fontInfo.FaceName = name;
            fontInfo.dwFontSize = new COORD { X = xSize, Y = ySize };

            SetCurrentConsoleFontEx(hConsole, false, ref fontInfo);
        }

        public static void MaximizeConsoleWindow()
        {
            IntPtr consoleWindowHandle = GetConsoleWindow();
            ShowWindow(consoleWindowHandle, SW_MAXIMIZE);
        }

        public static void FillConsoleBuffer(string output)
        {
            IntPtr hConsole = GetStdHandle(-11);
            COORD writeCoord = new COORD { X = 0, Y = 0 };

            uint charsWritten;
            WriteConsoleOutputCharacter(hConsole, output, (uint)output.Length, writeCoord, out charsWritten);
        }

        public static void FillConsoleAttributeBuffer(ushort[] attributes)
        {
            IntPtr hConsole = GetStdHandle(-11);
            COORD writeCoord = new COORD { X = 0, Y = 0 };

            uint attributesWritten;
            WriteConsoleOutputAttribute(hConsole, attributes, (uint)attributes.Length, writeCoord, out attributesWritten);
        }

        public static void DisableResize()
        {
            IntPtr handle = GetConsoleWindow();
            IntPtr sysMenu = GetSystemMenu(handle, false);

            if (handle != IntPtr.Zero)
            {
                DeleteMenu(sysMenu, SC_MAXIMIZE, MF_BYCOMMAND);
                DeleteMenu(sysMenu, SC_SIZE, MF_BYCOMMAND);
            }
        }

        public static ConsoleColor FindClosestConsoleColor(int r, int g, int b)
        {
            ConsoleColor closestColor = ConsoleColor.Black;
            double closestDistance = double.MaxValue;

            foreach (ConsoleColor consoleColor in Enum.GetValues(typeof(ConsoleColor)))
            {
                // Получаем RGB компоненты для цвета консоли
                int consoleR, consoleG, consoleB;
                (consoleR, consoleG, consoleB) = ConsoleColorToRGB(consoleColor);

                // Вычисляем расстояние между текущим цветом и целевым цветом
                double distance = Math.Sqrt(Math.Pow(consoleR - r, 2) + Math.Pow(consoleG - g, 2) + Math.Pow(consoleB - b, 2));

                // Обновляем ближайший цвет, если найден новый минимум
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestColor = consoleColor;
                }
            }

            return closestColor;
        }

        public static (int, int, int) ConsoleColorToRGB(ConsoleColor color)
        {
            switch (color)
            {
                case ConsoleColor.Black:
                    return (0, 0, 0);
                case ConsoleColor.DarkBlue:
                    return (0, 0, 128);
                case ConsoleColor.DarkGreen:
                    return (0, 128, 0);
                case ConsoleColor.DarkCyan:
                    return (0, 128, 128);
                case ConsoleColor.DarkRed:
                    return (128, 0, 0);
                case ConsoleColor.DarkMagenta:
                    return (128, 0, 128);
                case ConsoleColor.DarkYellow:
                    return (128, 128, 0);
                case ConsoleColor.Gray:
                    return (128, 128, 128);
                case ConsoleColor.DarkGray:
                    return (64, 64, 64);
                case ConsoleColor.Blue:
                    return (0, 0, 255);
                case ConsoleColor.Green:
                    return (0, 255, 0);
                case ConsoleColor.Cyan:
                    return (0, 255, 255);
                case ConsoleColor.Red:
                    return (255, 0, 0);
                case ConsoleColor.Magenta:
                    return (255, 0, 255);
                case ConsoleColor.Yellow:
                    return (255, 255, 0);
                case ConsoleColor.White:
                    return (255, 255, 255);
                default:
                    throw new ArgumentException("Invalid ConsoleColor");
            }
        }
    }
}

