using MediatR;

namespace Morango.Application.Security.Account.UseCases.SendResetPassword
{
    public record class Request(
        string Email
    ) : IRequest<Response>;
}