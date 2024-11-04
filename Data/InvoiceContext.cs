using Invoice.Models;
using Microsoft.EntityFrameworkCore;

namespace Invoice.Data
{
    public class InvoiceContext:DbContext
    {
        public InvoiceContext(DbContextOptions<InvoiceContext> options): base(options)
        {
        }
        public DbSet<InvoiceModel> Invoice { get; set; }
        public DbSet<CompanyModel> Company { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvoiceModel>().ToTable("Invoice");
            modelBuilder.Entity<CompanyModel>().ToTable("Company");
            base.OnModelCreating(modelBuilder);
        }
    }
}
