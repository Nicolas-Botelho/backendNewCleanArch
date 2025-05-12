using Morango.Domain.Entities;
using Morango.Domain.Enums;
using Morango.Domain.Interfaces.Entities;
using Morango.Infrastructure.Context;
using ConectaFapes.Common.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Morango.Infrastructure.Repositories.Entities
{
    public class AgricultorRepository : BaseRepository<Agricultor>, IAgricultorRepository
    {
        public AgricultorRepository(AppDbContext context) : base(context) { }

    }
}
