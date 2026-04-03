using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace ECart.BAL.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Pls Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Pls Enter Price")]
        public double Price { get; set; }
    }
}
