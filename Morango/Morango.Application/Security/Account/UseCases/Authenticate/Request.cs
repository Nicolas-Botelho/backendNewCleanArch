using MediatR;

namespace Morango.Application.Security.Account.UseCases.Authenticate
{

    public record Request(
        string Email,
        string Password
    ) : IRequest<Response>;
}