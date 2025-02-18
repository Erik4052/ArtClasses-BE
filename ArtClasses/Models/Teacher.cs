using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtClasses.Models
{
    public class Teacher
    {
        public Guid Id { get; set; }

        public User User { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        [Required]
        [MaxLength(500)]
        public string Bio { get; set; }

        [Required]
        [MaxLength(500)]
        public string ProfilePicture { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }


    }
}
