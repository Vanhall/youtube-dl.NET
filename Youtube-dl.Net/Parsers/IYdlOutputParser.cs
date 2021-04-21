namespace YoutubeDl.Parsers
{
    public interface IYdlOutputParser<out TResult>
    {
        void Parse(string input);
        TResult GetResult();
    }
}
