using MediatR;
using Morango.Application.Security.Account.UseCases.Authenticate;

namespace Morango.Application.Security.Account.UseCases.Verify
{
    public record Request(string Code) : IRequest<Response>;
}