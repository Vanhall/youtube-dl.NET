namespace YoutubeDl.Options
{
    public static class VideoSelectionOptionsExtensions
    {
        public static YdlOptions PlatlistStart(this YdlOptions o, int startNumber) =>
            o.AddOption(new ParametrizedOption<int>("--playlist-start", startNumber));
        public static YdlOptions PlatlistEnd(this YdlOptions o, int endNumber) =>
            o.AddOption(new ParametrizedOption<int>("--playlist-end", endNumber));
        public static YdlOptions PlatlistItems(this YdlOptions o, string items) =>
            o.AddOption(new ParametrizedOption<string>("--playlist-items", items));
        public static YdlOptions MatchTitle(this YdlOptions o, string regexPattern) =>
            o.AddOption(new ParametrizedOption<string>("--match-title", regexPattern));
        public static YdlOptions RejectTitle(this YdlOptions o, string regexPattern) =>
            o.AddOption(new ParametrizedOption<string>("--reject-title", regexPattern));
        public static YdlOptions MaxDownloads(this YdlOptions o, int number) =>
            o.AddOption(new ParametrizedOption<int>("--max-downloads", number));
        public static YdlOptions MinFilesize(this YdlOptions o, string size) =>
            o.AddOption(new ParametrizedOption<string>("--min-filesize", size));
        public static YdlOptions MaxFilesize(this YdlOptions o, string size) =>
            o.AddOption(new ParametrizedOption<string>("--max-filesize", size));
        public static YdlOptions Date(this YdlOptions o, string date) =>
            o.AddOption(new ParametrizedOption<string>("--date", date));
        public static YdlOptions DateBefore(this YdlOptions o, string date) =>
            o.AddOption(new ParametrizedOption<string>("--datebefore", date));
        public static YdlOptions DateAfter(this YdlOptions o, string date) =>
            o.AddOption(new ParametrizedOption<string>("--dateafter", date));
        public static YdlOptions MinViews(this YdlOptions o, int count) =>
            o.AddOption(new ParametrizedOption<int>("--min-views", count));
        public static YdlOptions MaxViews(this YdlOptions o, int count) =>
            o.AddOption(new ParametrizedOption<int>("--max-views", count));
        public static YdlOptions MatchFilter(this YdlOptions o, string filter) =>
            o.AddOption(new ParametrizedOption<string>("--match-filter", filter));
        public static YdlOptions NoPlaylist(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--no-playlist"));
        public static YdlOptions YesPlaylist(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--yes-playlist"));
        public static YdlOptions AgeLimit(this YdlOptions o, int years) =>
            o.AddOption(new ParametrizedOption<int>("--age-limit", years));
        public static YdlOptions DownloadArchive(this YdlOptions o, string filename) =>
            o.AddOption(new ParametrizedOption<string>("--download-archive", filename));
        public static YdlOptions IncludeAds(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--include-ads"));
    }
}
