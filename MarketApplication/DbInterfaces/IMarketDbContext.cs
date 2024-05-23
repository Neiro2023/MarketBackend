using MarketDomain;
using Microsoft.EntityFrameworkCore;

namespace MarketApplication.DbInterfaces
{
    public interface IMarketDbContext
    {
        DbSet<Product> Products { get; set; }
        Task<int> SaveChangesAsync(CancellationToken token);
    }
}
