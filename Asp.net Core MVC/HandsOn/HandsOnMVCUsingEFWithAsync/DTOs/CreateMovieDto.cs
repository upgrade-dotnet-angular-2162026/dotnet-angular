using System.ComponentModel.DataAnnotations;

namespace HandsOnMVCUsingEFWithAsync.DTOs
{
    public class CreateMovieDto
    {
        [Required(ErrorMessage ="Pls Enter Movie Title")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Pls Enter Year")]
        public int ReleaseYear { get; set; }
        [Required(ErrorMessage = "Pls Enter Director")]
        public string? Director { get; set; }
    }
}
