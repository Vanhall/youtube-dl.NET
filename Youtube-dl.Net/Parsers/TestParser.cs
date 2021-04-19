using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeDl
{
    public class TestParser : IYdlOutputParser<string>
    {
        public string GetResult()
        {
            return "[Parser] Done";
        }

        public void Parse(string input)
        {
            if (!string.IsNullOrEmpty(input))
                Console.WriteLine("[Task] " + input);
        }
    }
}
