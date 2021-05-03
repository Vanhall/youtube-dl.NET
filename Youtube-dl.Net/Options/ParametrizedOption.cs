namespace YoutubeDl.Options
{
    public class ParametrizedOption<TParam> : YdlOptionBase
    {
        private readonly TParam parameters;

        public ParametrizedOption(string key, TParam parameters)
        {
            this.key = key;
            this.parameters = parameters;
        }

        public override string ToString() => $"{key} {parameters}";
    }
}
