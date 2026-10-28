using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookStore.Domain.Entities;

namespace OnlineBookStore.Infrastructure.Configurations
{
    /*id : int, clé primaire.
    author_id : int, clé étrangère obligatoire vers authors.id.
    subject_id : int, clé étrangère obligatoire vers subjects.id.
    title : string, obligatoire, maximum 200 caractères.
    isbn : string, obligatoire et unique, contenant un ISBN-13 valide de 13 chiffres, enregistré sans
    séparateurs.
    page_count : int, strictement supérieur à 0.
    stock_quantity : int, supérieur ou égal à 0. Déplacer vers le vendeur
    price : decimal, précision (10,2), strictement supérieur à 0. Déplacer vers le vendeur
    publish_year : int, compris entre 1450 et l’année courante.
     */

    public class BookConfiguration:IEntityTypeConfiguration<Book>
    {
        void IEntityTypeConfiguration<Book>.Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(b => b.Isbn)
                .IsRequired()
                .HasMaxLength(13);
            builder.HasIndex(b => b.Isbn)
                .IsUnique();
            builder.Property(b => b.Price)
                .IsRequired()
                .HasColumnType("decimal(10,2)");
            builder.HasOne(b => b.Author)
               .WithMany(a => a.Books)
               .HasForeignKey(b => b.AuthorId);

            builder.HasOne(b => b.Subject)
                .WithMany(s => s.Books)
                .HasForeignKey(b => b.SubjectId);
        }
    }
}
