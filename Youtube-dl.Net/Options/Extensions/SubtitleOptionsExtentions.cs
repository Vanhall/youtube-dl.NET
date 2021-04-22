namespace YoutubeDl.Options
{
    public static class SubtitleOptionsExtentions
    {
        public static YdlOptions WriteSub(this YdlOptions o) => o.AddOption(new SwitchOption("--write-sub"));
        public static YdlOptions WriteAutoSub(this YdlOptions o) => o.AddOption(new SwitchOption("--write-auto-sub"));
        public static YdlOptions AllSubs(this YdlOptions o) => o.AddOption(new SwitchOption("--all-subs"));
        public static YdlOptions ListSubs(this YdlOptions o) => o.AddOption(new SwitchOption("--list-subs"));
        public static YdlOptions SubFormat(this YdlOptions o, string format) =>
            o.AddOption(new ParametrizedOption<string>("--sub-format", format));
        public static YdlOptions SubLang(this YdlOptions o, string languages) =>
            o.AddOption(new ParametrizedOption<string>("--sub-lang", languages));
    }
}
