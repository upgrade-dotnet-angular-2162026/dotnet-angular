namespace ECommService.DTOs
{
    public class UserReadDto
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Role { get; set; }
        public string? Token { get; set; }
    }
}
