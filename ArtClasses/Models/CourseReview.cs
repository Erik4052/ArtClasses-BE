using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtClasses.Models
{
    public class CourseReview
    {
        [Key]
        public Guid Id { get; set; }

        public User User { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        public Course Course { get; set; }

        [Required]
        [ForeignKey("CourseId")]
        public string CourseId { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; } // 1-5 stars

        public string Comment { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
