namespace EComm.OrderService.DTOs
{
    public class ReadOrderDto
    {
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}
