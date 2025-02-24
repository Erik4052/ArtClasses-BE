using System.ComponentModel.DataAnnotations;

namespace ArtClasses.Application.DTOs
{
    public class CreateTeacherDto : BaseTeacherDto
    {
        [Required]
        public Guid UserId { get; set; }
    }
}
