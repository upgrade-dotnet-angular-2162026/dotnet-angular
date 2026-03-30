using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCUsingHelperMethods.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Pls Enter Username")]
        public string? Username { get; set; }
        [Required(ErrorMessage ="Pls Enter Password")]
        public string? Password { get; set; }
        //public int EnterCaptch { get; set; }
    }
}
