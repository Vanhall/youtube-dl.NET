using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeDl
{
    public interface IYdlOutputParser<out TResult>
    {
        TResult Parse(string input);
    }
}
