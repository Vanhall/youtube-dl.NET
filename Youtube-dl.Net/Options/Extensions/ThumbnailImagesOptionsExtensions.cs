namespace YoutubeDl.Options
{
    public static class ThumbnailImagesOptionsExtensions
    {
        public static YdlOptions WriteThumbnail(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--write-thumbnail"));
        public static YdlOptions WriteAllThumbnails(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--write-all-thumbnails"));
        public static YdlOptions ListThumbnails(this YdlOptions o) =>
            o.AddOption(new SwitchOption("--list-thumbnails"));
    }
}
