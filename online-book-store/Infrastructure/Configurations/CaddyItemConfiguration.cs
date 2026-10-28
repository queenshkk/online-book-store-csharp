using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookStore.Domain.Entities;

namespace OnlineBookStore.Infrastructure.Configurations
{
    public class CaddyItemConfiguration:IEntityTypeConfiguration<CaddyItem>
    {
        /*id : int, clé primaire.
        caddyId : int, clé étrangère obligatoire vers caddies.id.
        bookId : int, clé étrangère obligatoire vers books.id.
        sellerId : int, clé étrangère obligatoire vers seller.id.
        quantity : int, strictement supérieur à 0.
        */

        public void Configure(EntityTypeBuilder<CaddyItem> builder)
        {
            builder.HasIndex(ci => new { ci.CaddyId, ci.BookId, ci.SellerId })
                .IsUnique();

            builder.HasOne(ci => ci.Caddy)
              .WithMany(c => c.CaddyItems)
              .HasForeignKey(ci => ci.CaddyId);

            builder.HasOne(ci => ci.Book)
                .WithMany(b => b.CaddyItems)
                .HasForeignKey(ci => ci.BookId);

            builder.HasOne(ci => ci.Seller)
                .WithMany(s => s.CaddyItems)
                .HasForeignKey(ci => ci.SellerId);

        }
    }
    

    
}
