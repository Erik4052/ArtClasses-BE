using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtClasses.Models
{
    public class Subscription
    {
        [Key]
        public Guid Id { get; set; }
        public User User { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public Guid UserId { get; set; } // Foreign Key


        [Required]
        public string PlanType { get; set; } // "Monthly", "Yearly"

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime StartDate { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime EndDate { get; set; } // Auto-renewal handled in Payments Microservice

        public bool AutoRenew { get; set; } = true; // Default to auto-renew
    }
}
