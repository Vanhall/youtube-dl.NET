using System;

namespace YoutubeDl.Options
{
    public static class WorkaroundsOptionsExtentions
    {
        public static YdlOptions Encoding(this YdlOptions o, string encoding) =>
            o.AddOption(new ParametrizedOption<string>("--encoding", encoding));
        public static YdlOptions NoCheckCertificate(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--no-check-certificate"));
        public static YdlOptions PreferInsecure(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--prefer-insecure"));
        public static YdlOptions UserAgent(this YdlOptions o, string userAgent) =>
            o.AddOption(new ParametrizedOption<string>("--user-agent", userAgent));
        public static YdlOptions Referer(this YdlOptions o, string url) =>
            o.AddOption(new ParametrizedOption<string>("--referer", url));
        public static YdlOptions AddHeader(this YdlOptions o) =>
            throw new NotImplementedException();
        public static YdlOptions BidiWorkaround(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--bidi-workaround"));
        public static YdlOptions SleepInterval(this YdlOptions o, int seconds) =>
            o.AddOption(new ParametrizedOption<int>("--sleep-interval", seconds));
        public static YdlOptions MaxSleepInterval(this YdlOptions o, int seconds) =>
            o.AddOption(new ParametrizedOption<int>("--max-sleep-interval", seconds));
    }
}
