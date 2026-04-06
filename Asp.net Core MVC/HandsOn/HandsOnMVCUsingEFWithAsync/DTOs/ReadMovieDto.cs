using System.ComponentModel.DataAnnotations;

namespace HandsOnMVCUsingEFWithAsync.DTOs
{
    public class ReadMovieDto
    {
        
        public int MovieId { get; set; }
        public string? Title { get; set; }
        public int ReleaseYear { get; set; }
        public string? Director { get; set; }
        public string Rating { get; set; } = "4.5";
    }
}
