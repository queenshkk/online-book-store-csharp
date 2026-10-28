using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookStore.Domain.Entities;

namespace OnlineBookStore.Infrastructure.Configurations
{
    /*id : int, clé primaire.
    name : string, obligatoire, maximum 100 caractères.
    TVA : string, obligatoire et unique, maximum 30 caractères ; représente le numéro de TVA du
    vendeur.
    */
    public class SellerConfiguration:IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(s => s.TVA)
                .IsRequired()
                .HasMaxLength(30);
            builder.HasIndex(s => s.TVA)
                .IsUnique();
        }
    
    }
}
