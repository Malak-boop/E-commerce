using Microsoft.EntityFrameworkCore;

namespace E_commerce.Models
{
    public class My_Context:DbContext
    {
        public My_Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product>products { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
    }
}
