namespace YoutubeDl.Options
{
    public static class AdobePassOptionsExtentions
    {
        public static YdlOptions ApMso(this YdlOptions o, string mso) =>
            o.AddOption(new ParametrizedOption<string>("--ap-mso", mso));
        public static YdlOptions ApUsername(this YdlOptions o, string username) =>
            o.AddOption(new ParametrizedOption<string>("--ap-username", username));
        public static YdlOptions ApPassword(this YdlOptions o, string pass) =>
            o.AddOption(new ParametrizedOption<string>("--ap-password", pass));
        public static YdlOptions ApListMso(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--ap-list-mso"));
    }
}
