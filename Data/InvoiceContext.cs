using Invoice.Models;
using Microsoft.EntityFrameworkCore;

namespace Invoice.Data
{
    public class InvoiceContext:DbContext
    {
        public InvoiceContext(DbContextOptions<InvoiceContext> options): base(options)
        {
        }
        public DbSet<UsersModel> User { get; set; }
        public DbSet<InvoiceModel> Invoice { get; set; }
        public DbSet<CompanyModel> Company { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersModel>().HasKey(u => u.Id);
            modelBuilder.Entity<CompanyModel>()
                .HasMany(x => x.Users)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyId)
                .HasPrincipalKey(x => x.Id);

            modelBuilder.Entity<InvoiceModel>()
                .HasMany(i => i.Company)
                .WithOne(i => i.Invoice)
                .HasForeignKey(i=>i.InvoiceId)
                .HasPrincipalKey(i => i.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
