namespace YoutubeDl.Parsers
{
    public class DoNothingParser : IYdlOutputParser<string>
    {
        public string GetResult() => "";

        public void Parse(string input)
        {
        }
    }
}
