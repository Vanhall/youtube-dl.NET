using System;
using System.Collections.Generic;
using System.Text;

namespace Ydl.Wrapper
{
    public interface IYdlOutputParser<out TResult>
    {
        TResult Parse(string input);
    }
}
