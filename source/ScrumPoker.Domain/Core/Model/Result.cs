using System;

namespace ScrumPoker.Domain.Core.Model
{
    public class Result
    {
        public Result(bool status)
        {
            Status = status;
        }

        public Result(bool status, Guid errorId) : this(status)
        {
            ErrorId = errorId;
        }

        public bool Status { get; }

        public Guid ErrorId { get; }

        public static Result True() => new Result(true);

        public static Result False(Guid errorId) => new Result(false, errorId);
    }

    public class Result<T>
    {
        public Result(bool status, T value)
        {
            Status = status;
            Value = value;
        }

        public Result(bool status, Guid errorId, T value) : this(status, value)
        {
            ErrorId = errorId;
        }

        public bool Status { get; }

        public Guid ErrorId { get; }

        public T Value { get; }

        public static Result<T> True(T value) => new Result<T>(true, value);

        public static Result<T> False(Guid errorId) => new Result<T>(false, errorId, default(T));
    }
}