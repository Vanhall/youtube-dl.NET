namespace YoutubeDl.Options
{
    public static class GeneralOptionsExtensions
    {
        public static YdlOptions IgnoreConfig(this YdlOptions o) => o.AddOption(new SwitchOption("--ignore-config"));

        public static YdlOptions Version(this YdlOptions o) => o.AddOption(new SwitchOption("--version"));
    }
}
