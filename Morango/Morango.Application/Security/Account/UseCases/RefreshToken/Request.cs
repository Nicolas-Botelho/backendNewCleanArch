using MediatR;
using Morango.Application.Security.Account.UseCases.Authenticate;

namespace Morango.Application.Security.Account.UseCases.RefreshToken
{
    public record Request(
        Guid RefreshToken
    ) : IRequest<Response>;
}