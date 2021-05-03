using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using YoutubeDl.ErrorHandlers;
using YoutubeDl.Options;
using YoutubeDl.Parsers;

namespace YoutubeDl
{
    public static class Ydl
    {
        public static string Version()
        {
            var wrapper = new YdlWrapper<IEnumerable<string>>(new AggregatingParser(), new DoNothingErrorHandler());
            wrapper.Options.Version();
            return wrapper.Execute().First();
        }

        public static bool IsInstalled()
        {
            var wrapper = new YdlWrapper<string>(new DoNothingParser(), new DoNothingErrorHandler());

            try
            {
                wrapper.Execute();
            }
            catch(Exception)
            {
                return false;
            }

            return true;
        }

        public static async Task<string> DownloadVideo(Uri Uri, CancellationToken ct)
        {
            var wrapper = new YdlWrapper<string>(new ConsolePassthroughParser<string>(), new ConsolePassthroughErrorHandler());
            wrapper.Options.IgnoreConfig();
            return await Task.Run(() => wrapper.Execute(ct, Uri));
        }
    }
}
