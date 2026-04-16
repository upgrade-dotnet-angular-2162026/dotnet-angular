using AutoMapper;
using EComm.ProductService.DTOs;
using EComm.ProductService.Entities;
namespace EComm.ProductService.Profiles
{
    public class ProductProfile: Profile
    {
        public ProductProfile() {
            //Define mapping configurations here
            CreateMap<Product, ReadProductDto>();
            CreateMap<CreateProductDto, Product>();
                CreateMap<Product, ReadProductDto>();
           
        }
    }
}
