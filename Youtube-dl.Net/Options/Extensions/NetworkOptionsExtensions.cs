namespace YoutubeDl.Options
{
    public static class NetworkOptionsExtensions
    {
        public static YdlOptions Proxy(this YdlOptions o, string url) =>
            o.AddOption(new ParametrizedOption<string>("--proxy", url));
        public static YdlOptions SocketTimeout(this YdlOptions o, int timeoutInSeconds) =>
            o.AddOption(new ParametrizedOption<int>("--socket-timeout", timeoutInSeconds));
        public static YdlOptions SourceAddress(this YdlOptions o, int ip) =>
            o.AddOption(new ParametrizedOption<int>("--source-address", ip));
        public static YdlOptions ForceIpv4(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-4"));
        public static YdlOptions ForceIpv6(this YdlOptions o) =>
            o.AddOption(new SwitchOption("-6"));
    }
}
