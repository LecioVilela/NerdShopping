using AutoMapper;
using NerdShopping.API.Data.ValueObjects;
using NerdShopping.API.Models;

namespace NerdShopping.API.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();

            });
            return mappingConfig;
        }
    }
}