using MediatR;

namespace Morango.Application.Security.Account.UseCases.ChangePassword
{
    public record class Request
    (
        string Code,
        string Password
    ) : IRequest<Response>;
}