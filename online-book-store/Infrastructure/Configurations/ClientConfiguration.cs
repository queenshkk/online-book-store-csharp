using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookStore.Domain.Entities;

namespace OnlineBookStore.Infrastructure.Configurations
{
    /*id : int, clé primaire et numéro de client.
     nom : string, obligatoire, maximum 50 caractères.
     prénom : string, obligatoire, maximum 50 caractères.
     email : string, obligatoire et unique, maximum 254 caractères, format valide.
     adresse : string, obligatoire, maximum 200 caractères.
     code_postal : string, obligatoire, maximum 20 caractères.
     ville : string, obligatoire, maximum 100 caractères.
     pays : string, obligatoire, maximum 100 caractères.
     telephone : string, facultatif, maximum 30 caractères.
     */
    public class ClientConfiguration:IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(254);
            builder.HasIndex(c => c.Email)
                .IsUnique();
            builder.Property(c => c.Address)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(c => c.PostalCode)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(c => c.City)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(c => c.Country)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(c => c.Telephone)
                .HasMaxLength(30);
        }
    }
}
