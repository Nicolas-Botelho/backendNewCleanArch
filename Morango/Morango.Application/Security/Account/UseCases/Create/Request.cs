using MediatR;

namespace Morango.Application.Security.Account.UseCases.Create
{
    public record Request(
        string Name,
        string Email,
        string Password
    ) : IRequest<Response>;
}