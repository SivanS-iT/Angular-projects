using WebPizzeria.Models;
using Microsoft.EntityFrameworkCore;

namespace WebPizzeria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }
    }
}
