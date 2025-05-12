using Microsoft.EntityFrameworkCore;
using Morango.Domain.Interfaces.Security;
using Morango.Domain.Security.Account.Entities;
using Morango.Infrastructure.Context;

namespace Morango.Infrastructure.Security.Repositories
{
    public class RoleRepository : BaseSecurityRepository<Role>, IRoleRepository
    {
        private readonly AppDbContext _context;
        public RoleRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Task<Role> GetRoleByName(string name, CancellationToken cancelationToken)
        {
            return _context.Roles.FirstOrDefaultAsync(x => x.Name == name, cancellationToken: cancelationToken);
        }
    }
}
