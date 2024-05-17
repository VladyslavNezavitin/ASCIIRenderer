using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Threading;

using Serialization;
using UltraShit.Console;


namespace ASCIIPlayer
{
    public class Program
    {
        [STAThread]
        private static void Main()
        {
            RenderData data = GetData();
            PerformConsoleSetup();
            DisplaySequence(data);
        }

        private static void PerformConsoleSetup()
        {
            ConsoleShit.SetConsoleFont(4, 4);
            Console.SetWindowSize(128, 128);
            Console.SetBufferSize(128, 128);
            Console.SetWindowSize(128, 128);
            Console.CursorVisible = false;
            
        }

        private static RenderData GetData()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = fileDialog.Filter = "Binary File (*.bin)|*.bin";

            while (true)
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = File.OpenRead(fileDialog.FileName))
                    {
                        if (stream == null)
                        {
                            throw new Exception($"Resource not found.");
                        }

                        return stream.DecompressAndDeserialize<RenderData>();
                    }
                }
            }
        }


        private static void DisplaySequence(RenderData data)
        {
            data.fps = 24;
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
    }
}
