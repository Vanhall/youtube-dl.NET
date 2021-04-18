using System;
using System.Collections.Generic;
using System.Text;

namespace Ydl.Wrapper
{
    public class ParametrizedOption<TParam> : OptionBase
    {
        private TParam parameters;

        public ParametrizedOption(string switchKey, TParam parameters)
        {
            this.switchKey = switchKey;
            this.parameters = parameters;
        }

        public override string ToString() => $"{switchKey} {parameters}";
    }
}
