using System;
using System.Diagnostics;
using System.Threading;

namespace Sandbox
{
    class Program
    {
        static bool ydlExited = false;
        static void Main(string[] args)
        {
            var ydlProcess = new Process();
            ydlProcess.StartInfo.FileName = "youtube-dl.exe";
            ydlProcess.StartInfo.UseShellExecute = false;
            ydlProcess.StartInfo.RedirectStandardOutput = true;
            ydlProcess.EnableRaisingEvents = true;
            ydlProcess.OutputDataReceived += YdlProcess_OutputDataReceived;
            ydlProcess.Exited += YdlProcess_Exited;

            Console.WriteLine("Input to pass to yt-dl:");
            var userInput = Console.ReadLine();
            ydlProcess.StartInfo.Arguments = userInput;

            ydlProcess.Start();
            ydlProcess.BeginOutputReadLine();

            while (!ydlExited)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Host Process writing");
                Thread.Sleep(500);
            }
        }

        private static void YdlProcess_Exited(object sender, EventArgs e)
        {
            ydlExited = true;
        }

        private static void YdlProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.ResetColor();
            Console.WriteLine(e.Data);
        }
    }
}
