using System.ComponentModel.DataAnnotations;

namespace ArtClasses.Application.DTOs
{
    public class BaseTeacherDto
    {
        [Required]
        [MaxLength(500)]
        public string Bio { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string ProfilePicture { get; set; } = string.Empty;
    }
}
