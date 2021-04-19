namespace YoutubeDl
{
    public static class GeneralOptionsExtensions
    {
        public static Options IgnoreConfig(this Options o) => o.AddOption(new SwitchOption("--ignore-config"));

        public static Options Version(this Options o) => o.AddOption(new SwitchOption("--version"));
    }
}
