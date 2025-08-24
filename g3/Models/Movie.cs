using System;
using System.ComponentModel.DataAnnotations;

namespace g3.Models
{
    public class Movie
    {
        public int Id { get; set; }   // Primary Key

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Genre { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(0, 10)]
        public decimal Rating { get; set; }

        // 🆕 New fields
        [Required]
        [StringLength(100)]
        public string Director { get; set; }

        [Range(1900, 2100)]
        public int ReleaseYear { get; set; }

        [Range(0, 1000)]
        public int CopiesAvailable { get; set; }

        [Url]
        public string PosterUrl { get; set; }   // For poster image

        [Url]
        public string TrailerUrl { get; set; }  // For trailer video (e.g. YouTube link)
    }
}
