using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Morango.Domain.Entities;

namespace Morango.Infrastructure.EntitiesConfiguration
{
    public class PropriedadeConfiguration : IEntityTypeConfiguration<Propriedade>
    {
        public void Configure(EntityTypeBuilder<Propriedade> builder)
        {
            builder.HasKey(x => x.Id);


        }
    }
}
