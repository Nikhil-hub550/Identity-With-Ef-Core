namespace StudentProject.DataAccess.Dtos
{
    public class SuccessResponse : ResponseBase
    {
        public SuccessResponse(string message = "Success") :
            base(statusCode: StatusCodes.Status200OK, succeeded: true, message: message)
        {

        }
    }
}
