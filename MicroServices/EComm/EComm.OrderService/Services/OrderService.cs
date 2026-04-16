using AutoMapper;
using EComm.OrderService.DTOs;

namespace EComm.OrderService.Services
{
    public class OrderService : IOrderService
    {
        private readonly Repositories.IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(Repositories.IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task CancelOrderAsync(Guid orderId)
        {
            await _orderRepository.CancelOrderAsync(orderId);
        }

        public async Task CreateOrderAsync(CreateOrderDto orderDto)
        {
            var order = _mapper.Map<Entities.Order>(orderDto);
            order.OrderId = Guid.NewGuid();
            order.OrderDate= DateTime.UtcNow;
            await _orderRepository.CreateOrderAsync(order);
        }

        public async Task<List<ReadOrderDto>> GetOrdersByUserIdAsync(string userId)
        {
            var orders = await _orderRepository.GetOrdersByUserIdAsync(userId);
            //convert orders to ReadOrderDto
            var orderDtos = _mapper.Map<List<ReadOrderDto>>(orders);
            return orderDtos;
        }
    }
}
