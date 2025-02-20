using ArtClasses.Application.DTOs;
using ArtClasses.Domain.Entities;

namespace ArtClasses.Application.Interfaces
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseDto>> GetAllCoursesAsync();
        Task<CourseDto> GetCourseByIdAsync(Guid id);
        Task AddCourseAsync(CreateCourseDto courseDto);
        Task UpdateCourseAsync(UpdateCourseDto courseDto);
        Task DeleteCourseAsync(Guid id);
    }
}
