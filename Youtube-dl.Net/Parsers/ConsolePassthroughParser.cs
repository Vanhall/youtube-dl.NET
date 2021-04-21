using System;
using YoutubeDl.Parsers;

namespace YoutubeDl
{
    public class ConsolePassthroughParser<T> : IYdlOutputParser<T>
    {
        private static readonly object ConsoleWriterLock = new object();
        public T GetResult()
        {
            return default;
        }

        public void Parse(string input)
        {
            lock (ConsoleWriterLock)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[YDL StdOut] " + input);
                Console.ResetColor();
            }
        }
    }
}
