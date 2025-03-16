namespace Final_Project.Abstractions
{
    public class Result<T>
    {
        public bool IsSuccess { get; }
        public int StatusCode { get; }
        public string[] Errors { get; }
        public T? Data { get; }

        private Result(bool isSuccess, int statusCode, string[] errors, T? data)
        {
            IsSuccess = isSuccess;
            StatusCode = statusCode;
            Errors = errors;
            Data = data;
        }

        // Success Result
        public static Result<T> Success(int statuscode, T data, string[] errors = null)
            => new(true, statuscode, errors, data);

        // Failure Result
        public static Result<T> Failure(int statuscode, string[] errors)
            => new(false, statuscode, errors, default);
    }
}
