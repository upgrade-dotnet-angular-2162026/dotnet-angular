namespace HandsOnMVCModels.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public string CustomerId { get; set;  }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
