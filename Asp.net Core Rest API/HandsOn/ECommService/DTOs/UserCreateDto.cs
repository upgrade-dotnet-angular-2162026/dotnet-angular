using System.ComponentModel.DataAnnotations;
namespace ECommService.DTOs
{
    public class UserCreateDto
    {
        public string? Name { get; set; }
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        [RegularExpression("[a-zA-Z]{6,8}",ErrorMessage ="Password should be 6 to 8 chars")]
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}
