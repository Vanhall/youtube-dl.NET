namespace YoutubeDl.Options
{
    public static class SimulationOptionsExtensions
    {
        public static YdlOptions Quiet(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-q"));
        public static YdlOptions NoWarnings(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--no-warnings"));
        public static YdlOptions Simulate(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-s"));
        public static YdlOptions SkipDownload(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--skip-download"));
        public static YdlOptions GetUrl(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-g"));
        public static YdlOptions GetTitle(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-e"));
        public static YdlOptions GetId(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--get-id"));
        public static YdlOptions GetThumbnail(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--get-thumbnail"));
        public static YdlOptions GetDescription(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--get-description"));
        public static YdlOptions GetDuration(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--get-duration"));
        public static YdlOptions GetFilename(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--get-filename"));
        public static YdlOptions GetFormat(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--get-format"));
        public static YdlOptions DumpJson(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-j"));
        public static YdlOptions DumpSingleJson(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-J"));
        public static YdlOptions PrintJson(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--print-json"));
        public static YdlOptions Newline(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--newline"));
        public static YdlOptions NoProgress(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--no-progress"));
        public static YdlOptions ConsoleTitle(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--console-title"));
        public static YdlOptions Verbose(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-v"));
        public static YdlOptions DumpPages(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--dump-pages"));
        public static YdlOptions WritePages(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--write-pages"));
        public static YdlOptions PrintTraffic(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--print-traffic"));
        public static YdlOptions CallHome(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-C"));
        public static YdlOptions NoCallHome(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--no-call-home"));
    }
}
