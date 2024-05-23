using AutoMapper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MarketApplication.Mappings
{
    public interface IMapWith<T>
    {
        void Maping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
