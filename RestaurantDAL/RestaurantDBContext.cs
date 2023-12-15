using Microsoft.EntityFrameworkCore;
using Restaurant.Model;

namespace RestaurantDAL
{
    public class RestaurantDBContext : DbContext
    {
        public RestaurantDBContext(DbContextOptions<RestaurantDBContext> options): base(options)
        {
            
        }
        public DbSet<Category> Category { get; set; }
    }
}
