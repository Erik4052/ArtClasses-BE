using System.ComponentModel.DataAnnotations;

namespace ArtClasses.Application.DTOs
{
    public class UpdateCourseDto
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public Guid TeacherId { get; set; }

        public string Category { get; set; }

        public string Thumbnail { get; set; }
    }
}
