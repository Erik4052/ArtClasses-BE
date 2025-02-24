using System.ComponentModel.DataAnnotations;

namespace ArtClasses.Application.DTOs
{
    public class UpdateTeacherDto:BaseTeacherDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
    }
}
