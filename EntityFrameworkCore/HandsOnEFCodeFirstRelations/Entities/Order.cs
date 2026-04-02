using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnEFCodeFirstRelations.Entities
{
    internal class Order
    {
        //Scalar Properties
        [Key]
        public string OrderId { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public int TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        //Navigation Property
       // [ForeignKey("ProductId")]
        public Product Products { get; set; }
    }
}
