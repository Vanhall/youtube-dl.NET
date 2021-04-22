namespace YoutubeDl.Options
{
    public static class DownloadOptionsExtentions
    {
        public static YdlOptions LimitRate(this YdlOptions o, string rate) =>
            o.AddOption(new ParametrizedOption<string>("-r", rate));
        public static YdlOptions Retries(this YdlOptions o, string retries) =>
            o.AddOption(new ParametrizedOption<string>("-R", retries));
        public static YdlOptions FragmentRetries(this YdlOptions o, string retries) =>
            o.AddOption(new ParametrizedOption<string>("--fragment-retries", retries));
        public static YdlOptions SkipUnavailableFragments(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--skip-unavailable-fragments"));
        public static YdlOptions AbortOnUnavailableFragment(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--abort-on-unavailable-fragment"));
        public static YdlOptions KeepFragments(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--keep-fragments"));
        public static YdlOptions BufferSize(this YdlOptions o, string size) =>
            o.AddOption(new ParametrizedOption<string>("--buffer-size", size));
        public static YdlOptions NoResizeBuffer(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--no-resize-buffer"));
        public static YdlOptions HttpChunkSize(this YdlOptions o, string size) =>
            o.AddOption(new ParametrizedOption<string>("--http-chunk-size", size));
        public static YdlOptions PlaylistReverse(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--playlist-reverse"));
        public static YdlOptions PlaylistRandom(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--playlist-random"));
        public static YdlOptions XattrSetFilesize(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--xattr-set-filesize"));
        public static YdlOptions HlsPreferNative(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--hls-prefer-native"));
        public static YdlOptions HlsPreferFfmpeg(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--hls-prefer-ffmpeg"));
        public static YdlOptions HlsUseMpgets(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--hls-use-mpegts"));
        public static YdlOptions ExternalDownloader(this YdlOptions o, string command) =>
            o.AddOption(new ParametrizedOption<string>("--external-downloader", command));
        public static YdlOptions ExternalDownloaderArgs(this YdlOptions o, string args) =>
            o.AddOption(new ParametrizedOption<string>("--external-downloader-args", args));
    }
}
