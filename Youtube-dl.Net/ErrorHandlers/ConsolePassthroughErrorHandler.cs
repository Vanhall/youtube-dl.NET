using System;

namespace YoutubeDl.ErrorHandlers
{
    public class ConsolePassthroughErrorHandler : IYdlErrorHandler
    {
        private static readonly object ConsoleWriterLock = new object();
        public void Handle(string input)
        {
            if (!string.IsNullOrEmpty(input))
                lock(ConsoleWriterLock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[YDL StdErr] " + input);
                    Console.ResetColor();
                }
        }
    }
}
