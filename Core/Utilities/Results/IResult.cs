using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //temel voidler için başlangış
    //işlem sonucu + user messages
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
