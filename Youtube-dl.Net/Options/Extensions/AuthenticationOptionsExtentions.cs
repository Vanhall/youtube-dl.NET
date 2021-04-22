namespace YoutubeDl.Options
{
    public static class AuthenticationOptionsExtentions
    {
        public static YdlOptions Username(this YdlOptions o, string username) =>
            o.AddOption(new ParametrizedOption<string>("-u", username));
        public static YdlOptions Password(this YdlOptions o, string pass) =>
            o.AddOption(new ParametrizedOption<string>("-p", pass));
        public static YdlOptions TwoFactor(this YdlOptions o, string code) =>
            o.AddOption(new ParametrizedOption<string>("--twofactor", code));
        public static YdlOptions Netrc(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-n"));
        public static YdlOptions VideoPassword(this YdlOptions o, string pass) =>
            o.AddOption(new ParametrizedOption<string>("--video-password", pass));
    }
}
