namespace YoutubeDl.Options
{
    public static class VideoFormatOptionsExtentions
    {
        public static YdlOptions Format(this YdlOptions o, string format) =>
            o.AddOption(new ParametrizedOption<string>("-f", format));
        public static YdlOptions AllFormats(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--all-formats"));
        public static YdlOptions PreferFreeFormats(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--prefer-free-formats"));
        public static YdlOptions ListFormats(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-F"));
        public static YdlOptions YoutubeSkipDashManifest(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--youtube-skip-dash-manifest"));
        public static YdlOptions MergeOutputFormat(this YdlOptions o, string format) =>
            o.AddOption(new ParametrizedOption<string>("--merge-output-format", format));
    }
}
