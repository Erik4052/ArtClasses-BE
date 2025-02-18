using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtClasses.Models
{
    public class Enrollment
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
        public Guid CourseId { get; set; }

        public DateTime PurchaseDate { get; set; } = DateTime.UtcNow;

        public string Status { get; set; }
    }
}
