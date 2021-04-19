using System.Diagnostics;
using System.Threading.Tasks;

namespace YoutubeDl
{
    public class YdlWrapper<TResult>
    {
        public Options Options { get; }

        private readonly IYdlOutputParser<TResult> parser;

        private readonly string ydlExePath;

        public YdlWrapper(IYdlOutputParser<TResult> parser, string ydlExePath = "youtube-dl.exe")
        {
            this.ydlExePath = ydlExePath;
            this.parser = parser;
            Options = new Options();
        }

        public TResult Execute(string Url = "")
        {
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
            ydl.WaitForExit();

            return parser.GetResult();
        }

        public async Task<TResult> ExecuteAsync(string Url = "") => await Task.Run(() => Execute(Url));

        private void Ydl_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            parser.Parse(e.Data);
        }

        private void Ydl_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            parser.Parse(e.Data);
        }
    }
}
