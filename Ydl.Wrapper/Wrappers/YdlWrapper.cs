using System;

namespace Ydl.Wrapper
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
