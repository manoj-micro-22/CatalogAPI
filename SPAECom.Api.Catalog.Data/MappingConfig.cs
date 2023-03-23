using AutoMapper;
using SPAECom.Api.Catalog.Data.Models;
using SPAECom.Api.Catalog.Data.Models.Dto;

namespace SPAECom.Api.Catalog.Data
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                //config.CreateMap<ProductDto, Product>();
                //config.CreateMap<Product, ProductDto>();
                config.CreateMap<Product, ProductDto>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
