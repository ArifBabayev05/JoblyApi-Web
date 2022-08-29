using System;
namespace Core.Utilities.Result
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        {
            Messsage = message;

        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Messsage { get; }
    }
}

