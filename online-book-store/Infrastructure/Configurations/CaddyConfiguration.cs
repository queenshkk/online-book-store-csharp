using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookStore.Domain.Entities;

namespace OnlineBookStore.Infrastructure.Configurations
{
    /*id : int, clé primaire.
       clientId : int, clé étrangère obligatoire vers clients.id.
       date : DateTime, obligatoire, date de création du panier.
       amount : decimal, précision (10,2), supérieur ou égal à 0, calculé par l’application.
       payed : bool, obligatoire, valeur par défaut false.
       */
    public class CaddyConfiguration:IEntityTypeConfiguration<Caddy>
    {
        public void Configure(EntityTypeBuilder<Caddy> builder)
        {
            builder.Property(c => c.Amount)
                 .HasColumnType("decimal(10,2)");
            builder.Property(c => c.Payed)
                .HasDefaultValue(false);
            builder.HasOne(c => c.Client)
                .WithMany(cl => cl.Caddies)
                .HasForeignKey(c => c.ClientId);
        }
    }
}
