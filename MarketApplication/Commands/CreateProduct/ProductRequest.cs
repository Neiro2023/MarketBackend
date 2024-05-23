using AutoMapper;
using MarketApplication.Mappings;
using MarketDomain;

namespace MarketApplication.Commands.CreateProduct
{
    public class ProductRequest : IMapWith<Product>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, ProductRequest>().
                ForMember(i => i.Name, i => i.MapFrom(i => i.Name)).
                ForMember(i => i.Description, i => i.MapFrom(i => i.Description)).
                ForMember(i => i.Price, i => i.MapFrom(i => i.Price));
        }
    }
}
