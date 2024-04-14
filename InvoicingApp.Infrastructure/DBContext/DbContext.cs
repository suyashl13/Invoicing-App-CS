using InvoicingApp.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRoles, Guid>
{

    private readonly bool _isMigration = true;

    public DbSet<Shop> Shops { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<InvoiceItem> InvoiceItems { get; set; }
    public DbSet<CustomerDetails> CustomerDetails { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>()
            .HasMany(user => user.Shops)
            .WithOne(shop => shop.Owner);
        
        builder.Entity<Shop>()
            .HasIndex(x => x.ShopId)
            .IsUnique();

        builder.Entity<Shop>()
            .HasMany(shop => shop.Invoices)
            .WithOne(invoice => invoice.Shop);
        
        builder.Entity<Invoice>()
            .HasMany(invoice => invoice.InvoiceItems)
            .WithOne(invoiceItem => invoiceItem.Invoice);           
            
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(""); // Your Sql Connection String here
    }

}