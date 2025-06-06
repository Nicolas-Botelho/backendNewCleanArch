using Flunt.Notifications;

namespace Morango.Application.Security.Account.UseCases.SendResetPassword
{
    public class Response : Shared.UseCases.Response
    {
        protected Response() { }
        public Response(
            string message,
            int status,
            IEnumerable<Notification>? notifications = null)
        {
            Message = message;
            Status = status;
            Notifications = notifications;
        }

        public Response(string message)
        {
            Message = message;
            Status = 200;
        }
    }
}