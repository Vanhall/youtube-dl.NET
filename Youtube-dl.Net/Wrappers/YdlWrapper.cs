using System;
using System.Diagnostics;
using System.Threading;
using YoutubeDl.ErrorHandlers;
using YoutubeDl.Options;
using YoutubeDl.Parsers;

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

        public TResult Execute(Uri Uri = null)
        {
            var ydl = new Process();
            InitializeYdlProcess(ydl, Uri);
            ydl.WaitForExit();
            ydl.Close();
            return parser.GetResult();
        }

        public TResult Execute(CancellationToken ct, Uri Uri = null, int cancellationCheckDelay = 100)
        {
            if (ct.IsCancellationRequested)
                return default;

            var ydl = new Process();
            InitializeYdlProcess(ydl, Uri);

            if (cancellationCheckDelay <= 0)
                ydl.WaitForExit();
            else
                while (!ydl.HasExited)
                {
                    if (ct.IsCancellationRequested)
                    {
                        ydl.Kill();
                        return default;
                    }

                    Thread.Sleep(cancellationCheckDelay);
                }

            ydl.Close();
            return parser.GetResult();
        }

        private void InitializeYdlProcess(Process process, Uri Uri)
        {
            var ydlProcessStartInfo = new ProcessStartInfo()
            {
                FileName = ydlExePath,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                Arguments = Uri == null ? $"{Options}" : $"{Options} {Uri}"
            };

            process.StartInfo = ydlProcessStartInfo;
            process.OutputDataReceived += Ydl_OutputDataReceived;
            process.ErrorDataReceived += Ydl_ErrorDataReceived;

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }

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
