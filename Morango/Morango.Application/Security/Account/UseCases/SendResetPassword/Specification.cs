using Flunt.Notifications;
using Flunt.Validations;


namespace Morango.Application.Security.Account.UseCases.SendResetPassword
{
    public static class Specification
    {
        public static Contract<Notification> Ensure(Request request) =>
           new Contract<Notification>()
               .Requires()
               .IsEmail(request.Email, "Email", "E-mail inválido");
    }
}