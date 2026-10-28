using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookStore.Domain.Entities;

namespace OnlineBookConfiguration.Infrastructure.Configurations
{
    /*id : int, clé primaire.
       name : string, obligatoire et unique, maximum 50 caractères.
       Relation : une catégorie peut contenir 0 à N livres.
       */
    public class SubjectConfiguration:IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasIndex(s => s.Name)
                .IsUnique();
        }

    }
}
