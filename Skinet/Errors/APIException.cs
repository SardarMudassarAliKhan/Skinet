namespace Skinet.Errors
{
    public class APIException : APIResponce
    {
        public string Details { get; set; }
        public APIException(int StatusCode, string message = null,string details=null) : base(StatusCode, message)
        {
            details = Details;
        }
    }
}
