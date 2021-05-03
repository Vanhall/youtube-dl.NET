namespace YoutubeDl.Options
{
    public static class PostProcessingOptonsExtentions
    {
        public static YdlOptions ExtractAudio(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-x"));
        public static YdlOptions AudioFormat(this YdlOptions o, string format) =>
            o.AddOption(new ParametrizedOption<string>("--audio-format", format));
        public static YdlOptions AudioQuality(this YdlOptions o, int quality) =>
            o.AddOption(new ParametrizedOption<int>("--audio-quality", quality));
        public static YdlOptions RecodeVideo(this YdlOptions o, string format) =>
            o.AddOption(new ParametrizedOption<string>("--recode-video", format));
        public static YdlOptions PostProcessorArgs(this YdlOptions o, string args) =>
            o.AddOption(new ParametrizedOption<string>("--postprocessor-args", args));
        public static YdlOptions KeepVideo(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-k"));
        public static YdlOptions NoPostOverwrites(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--no-post-overwrites"));
        public static YdlOptions EmbedSubs(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--embed-subs"));
        public static YdlOptions EmbedThumbnail(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--embed-thumbnail"));
        public static YdlOptions AddMetadata(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--add-metadata"));
        public static YdlOptions MetadataFromTitle(this YdlOptions o, string format) =>
            o.AddOption(new ParametrizedOption<string>("--metadata-from-title", format));
        public static YdlOptions Xattrs(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--xattrs"));
        public static YdlOptions Fixup(this YdlOptions o, string policy) =>
            o.AddOption(new ParametrizedOption<string>("--fixup", policy));
        public static YdlOptions PreferAvConv(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--prefer-avconv"));
        public static YdlOptions PreferFfmpeg(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--prefer-ffmpeg"));
        public static YdlOptions FfmpegLocation(this YdlOptions o, string path) =>
            o.AddOption(new ParametrizedOption<string>("--ffmpeg-location", path));
        public static YdlOptions Exec(this YdlOptions o, string command) =>
            o.AddOption(new ParametrizedOption<string>("--exec", command));
        public static YdlOptions ConvertSubs(this YdlOptions o, string format) =>
            o.AddOption(new ParametrizedOption<string>("--convert-subs", format));
    }
}
