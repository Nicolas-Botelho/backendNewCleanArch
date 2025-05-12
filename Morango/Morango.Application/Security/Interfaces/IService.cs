using Morango.Domain.Security.Account.Entities;

namespace Morango.Application.Security.Interfaces
{
    public interface IService
    {
        Task SendVerificationEmailAsync(User user, CancellationToken cancellationToken);
        Task SendResetPasswordAsync(User user, CancellationToken cancellationToken);
    }
}
