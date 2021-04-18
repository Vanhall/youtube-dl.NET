using System;
using System.Collections.Generic;
using System.Text;

namespace Ydl.Wrapper
{
    public abstract class OptionBase : IYdlOption
    {
        protected string switchKey;

        public override int GetHashCode() => switchKey.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is OptionBase other)
                return switchKey.Equals(other.switchKey);
            return false;
        }
    }
}
