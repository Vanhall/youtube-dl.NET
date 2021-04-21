using System.Diagnostics;
using System.Threading.Tasks;
using YoutubeDl.Options;
using YoutubeDl.Parsers;
using YoutubeDl.ErrorHandlers;
using System.Threading;

namespace YoutubeDl
{
    public class YdlWrapper<TResult>
    {
        public YdlOptions Options { get; }

        private readonly IYdlOutputParser<TResult> parser;

        private readonly IYdlErrorHandler errorHandler;

        private readonly string ydlExePath;

        public YdlWrapper(IYdlOutputParser<TResult> parser, IYdlErrorHandler errorHandler, string ydlExePath = "youtube-dl.exe")
        {
            this.ydlExePath = ydlExePath;
            this.parser = parser;
            this.errorHandler = errorHandler;
            Options = new YdlOptions();
        }

        public async Task<TResult> Execute(CancellationToken ct, string Url = "", int cancellationCheckDelay = 50) =>
            await Task.Run(() =>
            {
                if (ct.IsCancellationRequested) return default;

                var ydl = new Process();
                var ydlProcessStartInfo = new ProcessStartInfo()
                {
                    FileName = ydlExePath,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    Arguments = $"{Options} {Url}"
                };

                ydl.StartInfo = ydlProcessStartInfo;
                ydl.OutputDataReceived += Ydl_OutputDataReceived;
                ydl.ErrorDataReceived += Ydl_ErrorDataReceived;

                ydl.Start();
                ydl.BeginOutputReadLine();
                ydl.BeginErrorReadLine();

                if (cancellationCheckDelay <= 0)
                    ydl.WaitForExit();
                else
                    while (true)
                    {
                        if (ydl.HasExited)
                            break;

                        if (ct.IsCancellationRequested && !ydl.HasExited)
                        {
                            ydl.Kill();
                            return default;
                        }

                        Task.Delay(cancellationCheckDelay);
                    }

                ydl.Close();
                return parser.GetResult();
            });

        private void Ydl_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            parser.Parse(e.Data);
        }

        private void Ydl_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            errorHandler.Handle(e.Data);
        }

    }
}
