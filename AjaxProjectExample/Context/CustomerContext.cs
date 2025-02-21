using AjaxProjectExample.Entities;
using Microsoft.EntityFrameworkCore;

namespace AjaxProjectExample.Context
{
    public class CustomerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-B6FJQDJ\\SQLEXPRESS;Initial Catalog=CustomerAjaxDb;Integrated Security=True;TrustServerCertificate=True;");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
