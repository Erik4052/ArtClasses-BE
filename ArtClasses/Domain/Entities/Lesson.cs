using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtClasses.Domain.Entities
{
    public class Lesson
    {
        [Key]
        public Guid Id { get; set; }

        public Course Course { get; set; }

        [Required]
        [ForeignKey("CourseId")]
        public Guid CourseId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        public int Order { get; set; }

        public string VideoUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
