namespace YoutubeDl.Options
{
    public static class FilesystemOptionsExtensions
    {
        public static YdlOptions FilenameTemplate(this YdlOptions o, string format) =>
            o.AddOption(new ParametrizedOption<string>("-o", format));
    }
}
