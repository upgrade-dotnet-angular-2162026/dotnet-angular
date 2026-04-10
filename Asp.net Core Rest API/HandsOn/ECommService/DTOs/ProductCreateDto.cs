using System.ComponentModel.DataAnnotations;
namespace ECommService.DTOs
{
    public class ProductCreateDto
    {
        [Required(ErrorMessage ="Enter Name")]
        public string? Name { get; set; }
        [Range(1,9999,ErrorMessage ="Value must between 1,9999")]
        public int Price { get; set; }
        [Range(1,500,ErrorMessage ="Stock between 1 and 500")]
        public int Stock { get; set; }
    }
}
