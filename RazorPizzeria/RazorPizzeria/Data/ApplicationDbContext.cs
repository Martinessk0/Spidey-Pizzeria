using Microsoft.EntityFrameworkCore;
using RazorPizzeria.Models;

namespace RazorPizzeria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<PizzaOrder> PizzaOrders{ get; set; }
        public DbSet<PizzasModel> PizzasModels { get; set; }
    }
}
