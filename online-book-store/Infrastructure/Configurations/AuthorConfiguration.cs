using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookStore.Domain.Entities;

namespace OnlineBookStore.Infrastructure.Configurations
{
    /*Auteur — authors
      id : int, clé primaire.
      last_name : string, obligatoire, maximum 50 caractères.
      first_name : string, obligatoire, maximum 50 caractères.
      birth_date : DateOnly ou DateTime, obligatoire, antérieure à la date du jour.
      */
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(a => a.LastName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(a => a.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasMany(a => a.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorId);
        }
    }
}
