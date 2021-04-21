using System.Collections.Generic;

namespace YoutubeDl.Options
{
    public class YdlOptions
    {
        private readonly HashSet<IYdlOption> options = new HashSet<IYdlOption>();

        public bool TryAddOption(IYdlOption option) => options.Add(option);

        public YdlOptions AddOption(IYdlOption option)
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
