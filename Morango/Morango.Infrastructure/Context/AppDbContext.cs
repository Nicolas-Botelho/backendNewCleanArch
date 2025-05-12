using Microsoft.EntityFrameworkCore;
using Morango.Domain.Entities;
using Morango.Domain.Security.Account.Entities;

namespace Morango.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Agricultor> Agricultors { get; set; }
        public DbSet<Propriedade> Propriedades { get; set; }

    }
}
