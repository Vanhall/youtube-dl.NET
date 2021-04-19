using System;
using System.Threading;
using YoutubeDl;

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

                YdlWrapper<string> testWrapper = new YdlWrapper<string>(new TestParser());
                testWrapper.Options.IgnoreConfig().Version();
                var t = testWrapper.ExecuteAsync(userInput);
                while (!t.IsCompleted)
                {
                    WriteMessage(ConsoleColor.Green, "[HOST]", "host process writing");
                    Thread.Sleep(250);
                }
                Console.WriteLine(t.Result);
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
