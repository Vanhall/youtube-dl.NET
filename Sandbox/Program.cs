using System;
using System.Threading;
using YoutubeDl;
using YoutubeDl.ErrorHandlers;
using YoutubeDl.Options;
using YoutubeDl.Parsers;

namespace Sandbox
{
    class Program
    {
        private static readonly object ConsoleWriterLock = new object();

        static void Main(string[] args)
        {
            YdlWrapper<string> testWrapper = new YdlWrapper<string>(
                new ConsolePassthroughParser<string>(),
                new ConsolePassthroughErrorHandler());

            testWrapper.Options.IgnoreConfig();

            while (true)
            {
                Console.WriteLine("Input to pass to yt-dl (type \"exit\" to stop):");
                var userInput = Console.ReadLine();

                if (userInput == "exit")
                    break;

                var cancellationSource = new CancellationTokenSource();
                var t = testWrapper.Execute(cancellationSource.Token, userInput);

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
