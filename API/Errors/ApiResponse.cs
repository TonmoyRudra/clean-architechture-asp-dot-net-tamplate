namespace API.Errors
{
    public class ApiResponse
    {
        public int StatusCode;
        public string Message;

        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultErrorMessage(statusCode);
        }

        private string GetDefaultErrorMessage(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request, you have made",
                401 => "Authorized, you are not",
                404 => "Resource not found",
                500 => "Errors are the path to the dark side. Errors lead to anger.  Anger leads to hate.  Hate leads to career change",
                _ => null
            };

           
        }
    }
}
