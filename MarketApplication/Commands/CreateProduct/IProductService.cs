namespace MarketApplication.Commands.CreateProduct
{
    public interface IProductService
    {
        Task<Guid> CreateProduct(ProductRequest request, CancellationToken cancellationToken);
    }
}
