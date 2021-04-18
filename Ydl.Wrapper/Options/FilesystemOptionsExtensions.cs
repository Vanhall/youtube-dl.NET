using System;
using System.Collections.Generic;
using System.Text;

namespace Ydl.Wrapper
{
    public static class FilesystemOptionsExtensions
    {
        public static Options FilenameTemplate(this Options o, string format)
        {
            o.options.Add(new ParametrizedOption<string>("-o", format));
            return o;
        }
    }
}
