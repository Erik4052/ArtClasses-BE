using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtClasses.Domain.Entities
{
    public class Notification
    {
        [Key]
        public Guid Id { get; set; }

        public User User { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public Guid UserId { get; set; } // Who receives the notification

        public string Type { get; set; } // "ReviewReply", "RefundProcessed", etc.

        public string Message { get; set; } = string.Empty;

        public bool IsRead { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
