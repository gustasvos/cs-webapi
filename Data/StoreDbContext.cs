using StoreMysql.Models;
using Microsoft.EntityFrameworkCore;

namespace StoreMysql.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options): base(options)
        {

        }

        public DbSet<User> User { get; set; }
    }
}