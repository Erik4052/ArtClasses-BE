using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtClasses.Models
{
    public class ReviewReply
    {
        [Key]
        public Guid Id  { get; set; }

        public CourseReview CourseReview { get; set; }

        [Required]
        [ForeignKey("CourseReviewId")]
        public Guid ReviewId { get; set; }

        public Teacher Teacher { get; set; }

        [Required]
        [ForeignKey("TeacherId")]
        public Guid TeacherId { get; set; }

        public string ReplyText { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
