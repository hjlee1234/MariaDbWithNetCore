namespace MariaDbWithNetCore.Api.Types
{
    public class ExecutionResult<T>
    {
        public bool State { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }
}
