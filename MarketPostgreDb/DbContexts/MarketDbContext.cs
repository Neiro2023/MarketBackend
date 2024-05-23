using MarketApplication.DbInterfaces;
using MarketDomain;
using Microsoft.EntityFrameworkCore;

namespace MarketPostgreDb.DbContexts
{
    public class MarketDbContext : DbContext, IMarketDbContext
    {
        public DbSet<Product> Products { get; set; } = null!;

        public MarketDbContext(DbContextOptions<MarketDbContext> options) : base(options) { Database.EnsureCreated(); }

       
    }
}
