using System.ComponentModel.DataAnnotations;

namespace ArtClasses.Application.DTOs
{
    public class BaseCourseDto
    {
        [Required]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public Guid TeacherId { get; set; }

        public string Category { get; set; } = string.Empty;

        public string Thumbnail { get; set; } = string.Empty;
    }
}
