namespace HandsOnMVCUsingViewModel.Models
{
    public class Order
    {
        public string? OrderId { get; set;  }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public double TotalPrice { get; set;  }
        public DateTime OrderDate { get; set; }
    }
}
