namespace YoutubeDl.Options
{
    public static class GeneralOptionsExtensions
    {
        public static YdlOptions Help(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-h"));
        public static YdlOptions Version(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--version"));
        public static YdlOptions Update(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--update"));
        public static YdlOptions IgnoreErrors(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--ignore-errors"));
        public static YdlOptions AbortOnError(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--abort-on-error"));
        public static YdlOptions DumpUserAgent(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--dump-user-agent"));
        public static YdlOptions ListExtractors(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--list-extractors"));
        public static YdlOptions ListDescriptions(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--extractor-descriptions"));
        public static YdlOptions ForceGenericExtractor(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--force-generic-extractor"));
        public static YdlOptions DefaultSearch(this YdlOptions o, string prefix) =>
            o.AddOption(new ParametrizedOption<string>("--default-search", prefix));
        public static YdlOptions IgnoreConfig(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--ignore-config"));
        public static YdlOptions ConfigLocation(this YdlOptions o, string path) =>
            o.AddOption(new ParametrizedOption<string>("--config-location", path));
        public static YdlOptions FlatPlaylist(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--flat-playlist"));
        public static YdlOptions MarkWatched(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--mark-watched"));
        public static YdlOptions NoMarkWatched(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--no-mark-watched"));
        public static YdlOptions NoColor(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--no-color"));
    }
}
