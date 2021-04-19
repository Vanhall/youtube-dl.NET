namespace YoutubeDl
{
    public class SwitchOption : OptionBase
    {
        public SwitchOption(string key)
        {
            this.key = key;
        }

        public override string ToString() => key;
    }
}
