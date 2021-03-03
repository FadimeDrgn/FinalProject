using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        // get: Sadece okunabilir. -set:yazmak için
        bool Success { get; } 
        string Message { get; }

    }
}
