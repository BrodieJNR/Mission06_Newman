using System.ComponentModel.DataAnnotations;

namespace Mission06_Newman.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Category { get; set; } = null!;

        [Required]
        [Range(1888, 2100)]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; } = null!;

        [Required]
        public string Rating { get; set; } = null!; // G, PG, PG-13, R

        public bool? Edited { get; set; }          // optional
        public string? LentTo { get; set; }        // optional

        [StringLength(25)]
        public string? Notes { get; set; }         // optional, max 25 chars
    }
}
