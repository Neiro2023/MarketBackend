using MarketApplication.Commands.CreateProduct;
using Microsoft.AspNetCore.Mvc;

namespace MarketWebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MarketController : ControllerBase
    {
        private readonly IProductService _service;
        public MarketController(IProductService service)
        {
            _service = service;
        }

        [HttpPost("CreateProduct")]
        public async Task<Guid> CreateProduct(ProductRequest request, CancellationToken cancellationToken)
        {
            CreateProd create = _service.CreateProduct;
            return await create(request, cancellationToken);
        }
    }


    public delegate Task<Guid> CreateProd(ProductRequest request, CancellationToken cancellationToken);
}
