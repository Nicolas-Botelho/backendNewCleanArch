using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Morango.Domain.Entities;

namespace Morango.Infrastructure.EntitiesConfiguration
{
    public class AgricultorConfiguration : IEntityTypeConfiguration<Agricultor>
    {
        public void Configure(EntityTypeBuilder<Agricultor> builder)
        {
            builder.HasKey(x => x.Id);
            builder
                .HasMany<Propriedade>(agricultor => agricultor.Propriedades)
                .WithOne(propriedade => propriedade.Agricultor)
                .HasForeignKey(agricultor => agricultor.PropriedadeAgricultorId);


        }
    }
}
