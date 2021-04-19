namespace YoutubeDl
{
    public class ParametrizedOption<TParam> : OptionBase
    {
        private TParam parameters;

        public ParametrizedOption(string key, TParam parameters)
        {
            this.key = key;
            this.parameters = parameters;
        }

        public override string ToString() => $"{key} {parameters}";
    }
}
