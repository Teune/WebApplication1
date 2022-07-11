using Microsoft.EntityFrameworkCore;
using TonysPizzeria.Models;

namespace TonysPizzeria.Data
{
    public class ApplicationDbContext : DbContext  
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
