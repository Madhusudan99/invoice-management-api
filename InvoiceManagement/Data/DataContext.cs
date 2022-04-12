using InvoiceManagement.Models;
using Microsoft.EntityFrameworkCore;




namespace InvoiceManagement.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Client> clients { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<InvoiceDetail> invoices { get; set; }
        public DbSet<InvoiceItem> invoiceItems { get; set; }
        public DbSet<Company> companies { get; set; }




    }
}
