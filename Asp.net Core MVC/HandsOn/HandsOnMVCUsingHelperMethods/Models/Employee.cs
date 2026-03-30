using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCUsingHelperMethods.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Pls Enter Id")]
        public int Id { get; set;  }
        [Required(ErrorMessage = "Pls Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pls Enter Email")]
        [EmailAddress(ErrorMessage ="Pls Enter Valid Email")] //validate Email value
        public string Email { get; set; }
        [RegularExpression("[5-9][0-9]{9}",ErrorMessage ="Invalid Mobile no")]
        public string Mobile { get; set; }
        public double Salary { get; set; }
        [Required(ErrorMessage = "Pls Enter Exp")]
        [Range(5,10,ErrorMessage ="Exp in between 5 to 10 years")]
        public int Exp { get; set; }
        [Required(ErrorMessage = "Pls Enter Password")]
        [RegularExpression("[a-zA-Z]{6,8}",ErrorMessage ="Password should be 6 to 8 chars long")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password Mismatch")]
        public string ConfirmPassword { get; set; }
    }
}
