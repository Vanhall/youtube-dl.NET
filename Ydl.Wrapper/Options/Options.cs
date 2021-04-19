using System.Collections.Generic;

namespace YoutubeDl
{
    public class Options
    {
        private readonly HashSet<IYdlOption> options = new HashSet<IYdlOption>();

        public bool TryAddOption(IYdlOption option) => options.Add(option);

        public Options AddOption(IYdlOption option)
        {
            options.Add(option);
            return this;
        }

        public override string ToString()
        {
            return string.Join(" ", options);
        }
    }
}
