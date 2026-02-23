using System.ComponentModel.DataAnnotations;

namespace Mission06_Newman.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        // Remove Category, add CategoryId instead
        public int? CategoryId { get; set; }  // Nullable foreign key

        [Required]
        [Range(1888, 2100, ErrorMessage = "Year must be 1888 or later.")]
        public int Year { get; set; }

        public string? Director { get; set; } = null!;

        public string? Rating { get; set; }  // G, PG, PG-13, R

        [Required]
        public int Edited { get; set; }  // Database has this as INTEGER (1=yes, 0=no)

        public string? LentTo { get; set; }  // optional

        [StringLength(25)]
        public string? Notes { get; set; }  // optional, max 25 chars

        [Required]
        public int CopiedToPlex { get; set; }  // Required field, INTEGER in DB (1=yes, 0=no)
    }
}

