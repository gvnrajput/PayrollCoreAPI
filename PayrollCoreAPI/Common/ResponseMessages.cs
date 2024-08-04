namespace WebAPI.Common
{
    public static class ResponseMessages
    {
        // Success Messages
        public const string DataRetrievedSuccessfully = "Data retrieved successfully";
        public const string CreatedSuccessfully = "Resource created successfully";
        public const string DataUpdatedSuccessfully = "Data updated successfully";
        public const string DataDeletedSuccessfully = "Data deleted successfully";

        // Error Messages
        public const string NotFound = "Resource not found";
        public const string BadRequest = "Bad request";
        public const string InternalServerError = "An error occurred while processing your request";
        public const string IdMismatch = "ID mismatch";

        // Error Details (Optional)
        public static string GetErrorDetails(Exception ex)
        {
            return ex.Message; // Customize as needed
        }
    }
}
