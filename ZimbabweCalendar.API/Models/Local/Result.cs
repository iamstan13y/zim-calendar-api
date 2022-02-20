namespace ZimbabweCalendar.API.Models.Local
{
    public class Result<T>
    {
        public Result(bool Success, List<string> ErrorMessages)
        {
            this.Success = Success;
            this.ErrorMessages = ErrorMessages;
        }

        public Result(T Data)
        {
            this.Data = Data;
        }

        public bool Success { get; set; } = true;
        public T? Data { get; set; }
        public List<string>? ErrorMessages { get; set; }
    }
}
