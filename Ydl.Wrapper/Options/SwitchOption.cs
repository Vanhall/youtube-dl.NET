using System;
using System.Collections.Generic;
using System.Text;

namespace Ydl.Wrapper
{
    public class SwitchOption : OptionBase
    {
        public SwitchOption(string switchKey)
        {
            this.switchKey = switchKey;
        }

        public override string ToString() => switchKey;
    }
}
