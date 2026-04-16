using AutoMapper;
using EComm.ProductService.DTOs;
using EComm.ProductService.Entities;
namespace EComm.ProductService.Profiles
{
    public class ProductProfile: Profile
    {
        public ProductProfile() {
            //Define mapping configurations here
            CreateMap<Product, CreateProductDto>();
            CreateMap<CreateProductDto, Product>();
                CreateMap<Product, ReadProductDto>();
           
        }
    }
}
