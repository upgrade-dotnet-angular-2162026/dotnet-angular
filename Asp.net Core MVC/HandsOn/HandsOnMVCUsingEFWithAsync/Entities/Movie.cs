using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnMVCUsingEFWithAsync.Entities
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [StringLength(30)]
        [Required]
        public string? Title { get; set; }
        public int ReleaseYear { get; set; }
        [StringLength(30)]
        public string? Director { get; set; }
    }
}
