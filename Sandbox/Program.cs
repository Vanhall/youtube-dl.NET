using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using YoutubeDl;
using YoutubeDl.ErrorHandlers;
using YoutubeDl.Options;
using YoutubeDl.Parsers;

namespace Sandbox
{
    class Program
    {
        private static readonly object ConsoleWriterLock = new object();
        //https://www.youtube.com/watch?v=dQw4w9WgXcQ

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input to pass to yt-dl (type \"exit\" to stop):");
                var userInput = Console.ReadLine();

                if (userInput == "exit")
                    break;

                var cancellationSource = new CancellationTokenSource();
                var t = Ydl.DownloadVideo(new Uri(userInput), cancellationSource.Token);

                while (!t.IsCompleted)
                {
                    WriteMessage(ConsoleColor.Blue, "[HOST]", "host process writing");
                    Thread.Sleep(250);
                    if (Console.KeyAvailable)
                    {
                        cancellationSource.Cancel();
                        Console.ReadKey();
                        break;
                    }
                }

                Console.WriteLine(Ydl.Version());
                Console.WriteLine(Ydl.IsInstalled());
            }
        }

        private static void WriteMessage(ConsoleColor color, string prefix, string message)
        {
            lock (ConsoleWriterLock)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{prefix} {message}");
                Console.ResetColor();
            }
        }
    }
}
