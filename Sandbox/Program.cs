using System;
using System.Diagnostics;
using System.Threading;

namespace Sandbox
{
    class Program
    {
        private static readonly object ConsoleWriterLock = new object();

        static bool ydlExited = false;
        static void Main(string[] args)
        {
            var ydlProcess = new Process();
            ydlProcess.StartInfo.FileName = "youtube-dl.exe";
            ydlProcess.StartInfo.UseShellExecute = false;
            ydlProcess.StartInfo.RedirectStandardOutput = true;
            ydlProcess.StartInfo.RedirectStandardError = true;
            ydlProcess.EnableRaisingEvents = true;
            ydlProcess.OutputDataReceived += YdlProcess_OutputDataReceived;
            ydlProcess.ErrorDataReceived += YdlProcess_ErrorDataReceived;

            Console.WriteLine("Input to pass to yt-dl:");
            var userInput = Console.ReadLine();
            ydlProcess.StartInfo.Arguments = userInput;

            ydlProcess.Start();
            ydlProcess.BeginOutputReadLine();
            ydlProcess.BeginErrorReadLine();

            while (!ydlProcess.HasExited)
            {
                lock (ConsoleWriterLock)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("[HOST] Host Process writing");
                }
                Thread.Sleep(100);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            ydlProcess.Close();
        }

        private static void YdlProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            lock (ConsoleWriterLock)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[StdERR]: " + e.Data);
            }
        }

        private static void YdlProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            lock (ConsoleWriterLock)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("[StdIN]: " + e.Data);
            }
        }
    }
}
