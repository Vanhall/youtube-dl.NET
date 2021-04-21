namespace YoutubeDl.Options
{
    public class SwitchOption : YdlOptionBase
    {
        public SwitchOption(string key)
        {
            this.key = key;
        }

        public override string ToString() => key;
    }
}
