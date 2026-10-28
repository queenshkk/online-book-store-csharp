using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookStore.Domain.Entities;

namespace OnlineBookStore.Infrastructure.Configurations
{
    /*sellerId : int, clé étrangère obligatoire vers sellers.id.
   bookId : int, clé étrangère obligatoire vers books.id.
   quantity_in_stock et price (voir book).
   */
    public class SellerItemConfiguration:IEntityTypeConfiguration<SellerItem>
    {
        public void Configure(EntityTypeBuilder<SellerItem> builder)
        {
            builder.HasKey(si => new { si.SellerId, si.BookId });
            builder.Property(si => si.Price)
                .HasColumnType("decimal(10,2)");
            builder.HasOne(si => si.Seller)
                .WithMany(s => s.SellerItems)
                .HasForeignKey(si => si.SellerId);
            builder.HasOne(si => si.Book)
                .WithMany(b => b.SellerItems)
                .HasForeignKey(si => si.BookId);
        }
    }
}
