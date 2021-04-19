namespace YoutubeDl
{
    public interface IYdlOutputParser<out TResult>
    {
        void Parse(string input);
        TResult GetResult();
    }
}
