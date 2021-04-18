using System;
using System.Collections.Generic;
using System.Text;

namespace Ydl.Wrapper
{
    public static class GenericOptionsExtensions
    {
        private static Options AddSwitchOption(Options options, string switchKey)
        {
            options.options.Add(new SwitchOption(switchKey));
            return options;
        }

        public static Options IgnoreConfig(this Options o) => AddSwitchOption(o, "--ignore-config");

        public static Options Version(this Options o) => AddSwitchOption(o, "--version");
    }
}
