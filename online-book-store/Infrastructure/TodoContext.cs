using Microsoft.EntityFrameworkCore;
using OnlineBookConfiguration.Infrastructure.Configurations;
using OnlineBookStore.Domain.Entities;
using OnlineBookStore.Infrastructure.Configurations;

namespace OnlineBookStore.Infrastructure;

public class TodoContext(DbContextOptions<TodoContext> options) : DbContext(options)
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Caddy> Caddies { get; set; }
    public DbSet<CaddyItem> CaddyItems { get; set; }
    public DbSet<Seller> Sellers { get; set; }
    public DbSet<SellerItem> SellerItems { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new BookConfiguration());
        modelBuilder.ApplyConfiguration(new AuthorConfiguration());
        modelBuilder.ApplyConfiguration(new SubjectConfiguration());
        modelBuilder.ApplyConfiguration(new ClientConfiguration());
        modelBuilder.ApplyConfiguration(new CaddyConfiguration());
        modelBuilder.ApplyConfiguration(new CaddyItemConfiguration());
        modelBuilder.ApplyConfiguration(new SellerConfiguration());
        modelBuilder.ApplyConfiguration(new SellerItemConfiguration());
    }
}
