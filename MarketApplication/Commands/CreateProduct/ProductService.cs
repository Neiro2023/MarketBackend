using MarketApplication.DbInterfaces;
using MarketDomain;

namespace MarketApplication.Commands.CreateProduct
{
    public class ProductService : IProductService
    {
        private readonly IMarketDbContext _context;
        public ProductService(IMarketDbContext context) => _context = context;

        public async Task<Guid> CreateProduct(ProductRequest request, CancellationToken cancellationToken)
        {
            Product product = new Product { Name = request.Name, Description = request.Description, Price = request.Price };
            await _context.Products.AddAsync(product, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return product.Id;
        }
    }
}
