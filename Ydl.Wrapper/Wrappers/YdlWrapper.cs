using System;

namespace YoutubeDl
{
    public class YdlWrapper
    {
        Options opts = new Options();

        public void Foo()
        {
            opts
                .IgnoreConfig()
                .Version()
                .FilenameTemplate("kek");
        }
    }
}
