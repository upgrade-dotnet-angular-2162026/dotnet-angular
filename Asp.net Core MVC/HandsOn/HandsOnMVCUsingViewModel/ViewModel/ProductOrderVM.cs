namespace HandsOnMVCUsingViewModel.ViewModel
{
    public class ProductOrderVM
    {
        //having props of 2 or more models/entitie
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? OrderId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliverDate { get; set; }
    }
}
