namespace EComm.OrderService.DTOs
{
    public class CreateOrderDto
    {
       
        public string? UserId { get; set; }
       
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}
