using System;
using System.Collections.Generic;
using System.Text;

namespace Ydl.Wrapper
{
    public static class FilesystemOptionsExtensions
    {
        public static Options FilenameTemplate(this Options o, string format) =>
            o.AddOption(new ParametrizedOption<string>("-o", format));
    }
}
