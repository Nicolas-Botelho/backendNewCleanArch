using Morango.Domain.Security.Account.Entities;

namespace Morango.Domain.Interfaces.Security
{
    public interface IRoleRepository : IBaseSecurityRepository<Role>
    {
        Task<Role> GetRoleByName(string name, CancellationToken cancelationToken);
    }
}
