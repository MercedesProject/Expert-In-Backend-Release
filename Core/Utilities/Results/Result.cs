using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success) //this = Result.cs (success) = aşşağıdai constructerı da kapsar
        {
            Message = message;
        }

        //Mesaj göndermek istenmezse diye 2 costructor tanımlaması yapılıyor
        public Result(bool success)
        {

            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
