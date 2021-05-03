using System.Collections.Generic;

namespace YoutubeDl.Parsers
{
    public class AggregatingParser : IYdlOutputParser<IEnumerable<string>>
    {
        private readonly List<string> strings = new List<string>();

        public IEnumerable<string> GetResult() => strings;

        public void Parse(string input)
        {
            if (!string.IsNullOrEmpty(input))
                strings.Add(input);
        }
    }
}
