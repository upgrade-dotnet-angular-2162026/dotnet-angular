using AutoMapper;
namespace EComm.OrderService.Profiles
{
    public class OrderProfile:Profile
    {
        public OrderProfile()
        {
            //Define mapping configurations here
            //Example: CreateMap<Source, Destination>();
           
             CreateMap<Entities.Order, DTOs.ReadOrderDto>();
             CreateMap<DTOs.CreateOrderDto, Entities.Order>();
            
        }
    }
}
