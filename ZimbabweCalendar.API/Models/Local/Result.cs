namespace ZimbabweCalendar.API.Models.Local
{
    public class Result
    {
        public Result(bool Success, List<string> ErrorMessages)
        {
            this.Success = Success;
            this.ErrorMessages = ErrorMessages;
        }

        public Result(object Data)
        {
            this.Data = Data;
        }

        public bool Success { get; set; } = true;
        public object? Data { get; set; }
        public List<string>? ErrorMessages { get; set; }
    }
}
