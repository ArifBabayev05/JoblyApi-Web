using System;
namespace Core.Utilities.Result
{
    public interface IResult
    {
        bool Success { get; }

        string Messsage { get; }
    }
}

