using System;
using System.Diagnostics;
using System.IO;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var ydlProcess = new Process();
            ydlProcess.StartInfo.FileName = "youtube-dl.exe";
            ydlProcess.StartInfo.UseShellExecute = false;
            ydlProcess.StartInfo.RedirectStandardOutput = true;

            ydlProcess.OutputDataReceived += YdlProcess_OutputDataReceived;

            ydlProcess.StartInfo.RedirectStandardInput = true;

            ydlProcess.Start();

            StreamWriter inputStream = ydlProcess.StandardInput;

            ydlProcess.BeginOutputReadLine();

            Console.WriteLine("Input to pass to yt-dl:");
            var userInput = Console.ReadLine();
            inputStream.Write(userInput);
            inputStream.Close();

            ydlProcess.WaitForExit();
        }

        private static void YdlProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.Data);
        }
    }
}
