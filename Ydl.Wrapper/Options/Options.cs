using System.Collections.Generic;

namespace Ydl.Wrapper
{
    public class Options
    {
        public IList<IYdlOption> options { get; }

        public override string ToString()
        {
            return string.Join(" ", options);
        }
    }
}
