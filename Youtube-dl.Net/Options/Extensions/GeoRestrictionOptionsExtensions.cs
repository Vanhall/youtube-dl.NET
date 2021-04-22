namespace YoutubeDl.Options
{
    public static class GeoRestrictionOptionsExtensions
    {
        public static YdlOptions GeoVerificationProxy(this YdlOptions o, string url) =>
            o.AddOption(new ParametrizedOption<string>("--geo-verification-proxy", url));
        public static YdlOptions GeoBypass(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--geo-bypass"));
        public static YdlOptions NoGeoBypass(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--no-geo-bypass"));
        public static YdlOptions GeoBypassCountry(this YdlOptions o, string code) =>
            o.AddOption(new ParametrizedOption<string>("--geo-bypass-country", code));
        public static YdlOptions GeoBypassIpBlock(this YdlOptions o, string ipBlock) =>
            o.AddOption(new ParametrizedOption<string>("--geo-bypass-country", ipBlock));

    }
}
