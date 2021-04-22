namespace YoutubeDl.Options
{
    public static class FilesystemOptionsExtensions
    {
        public static YdlOptions BatchFile(this YdlOptions o, string filename) =>
            o.AddOption(new ParametrizedOption<string>("-a", filename));
        public static YdlOptions Id(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--id"));
        public static YdlOptions FilenameTemplate(this YdlOptions o, string format) =>
            o.AddOption(new ParametrizedOption<string>("-o", format));
        public static YdlOptions OutputNaPlaceholder(this YdlOptions o, string placeholder) =>
            o.AddOption(new ParametrizedOption<string>("--output-na-placeholder", placeholder));
        public static YdlOptions AutonumberStart(this YdlOptions o, int startNumber) =>
            o.AddOption(new ParametrizedOption<int>("--autonumber-start", startNumber));
        public static YdlOptions RestrictFilenames(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--restrict-filenames"));
        public static YdlOptions NoOverwrites(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-w"));
        public static YdlOptions Continue(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-c"));
        public static YdlOptions NoContinue(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--no-continue"));
        public static YdlOptions NoPart(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--no-part"));
        public static YdlOptions NoMTime(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--no-mtime"));
        public static YdlOptions WriteDesctiption(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--write-description"));
        public static YdlOptions WriteInfoJson(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--write-info-json"));
        public static YdlOptions WriteAnotations(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--write-annotations"));
        public static YdlOptions LoadInfoJson(this YdlOptions o, string filename) =>
            o.AddOption(new ParametrizedOption<string>("--load-info-json", filename));
        public static YdlOptions Cookies(this YdlOptions o, string filename) =>
            o.AddOption(new ParametrizedOption<string>("--cookies", filename));
        public static YdlOptions CacheDir(this YdlOptions o, string directory) =>
            o.AddOption(new ParametrizedOption<string>("--cache-dir", directory));
        public static YdlOptions NoCacheDir(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--no-cache-dir"));
        public static YdlOptions RmCacheDir(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--rm-cache-dir"));
    }
}
