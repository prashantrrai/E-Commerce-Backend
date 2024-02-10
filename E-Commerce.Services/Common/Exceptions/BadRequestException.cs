// BadRequestException class

namespace E_Commerce.Services.Common.Exceptions
{
    public class BadRequestException: Exception
    {
        public BadRequestException(string message) : base(message) { }

        public BadRequestException(string[] errors): base("Multiple ERRORS Occured. See error details.")
        {
            Errors = errors;
        }

        public string[] Errors { get;  set; }
    }
}
