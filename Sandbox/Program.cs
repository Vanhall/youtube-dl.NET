using System;
using System.Diagnostics;
using System.Threading;

namespace Sandbox
{
    class Program
    {
        private static readonly object ConsoleWriterLock = new object();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input to pass to yt-dl (type \"exit\" to stop):");
                var userInput = Console.ReadLine();

                if (userInput == "exit")
                    break;

                var ydlProcess = new Process();
                var ydlProcessStartInfo = new ProcessStartInfo()
                {
                    FileName = "youtube-dl.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    Arguments = userInput
                };

                ydlProcess.StartInfo = ydlProcessStartInfo;
                ydlProcess.OutputDataReceived += YdlProcess_OutputDataReceived;
                ydlProcess.ErrorDataReceived += YdlProcess_ErrorDataReceived;

                ydlProcess.Start();
                ydlProcess.BeginOutputReadLine();
                ydlProcess.BeginErrorReadLine();

                while (!ydlProcess.HasExited)
                {
                    WriteMessage(ConsoleColor.Gray, "[HOST]", "host process writing");
                    Thread.Sleep(250);
                }

                Console.ResetColor();
                ydlProcess.Close();
            }
        }

        private static void WriteMessage(ConsoleColor color, string prefix, string message)
        {
            lock (ConsoleWriterLock)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{prefix} {message}");
            }
        }

        private static void YdlProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            WriteMessage(ConsoleColor.Red, "[StdERR]", e.Data);
        }

        private static void YdlProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            WriteMessage(ConsoleColor.Green, "[StdOUT]", e.Data);
        }
    }
}
