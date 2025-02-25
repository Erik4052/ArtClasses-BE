using ArtClasses.Application.DTOs;

namespace ArtClasses.Application.Interfaces
{
    public interface ITeacherService
    {
        Task<IEnumerable<TeacherDto>> GetAllTeachersAsync();
        Task<TeacherDto> GetTeacherByIdAsync(Guid id);
        Task AddTeacherAsync(CreateTeacherDto teacherDto);
        Task UpdateTeacherAsync(UpdateTeacherDto teacherDto);
        Task DeleteTeacherAsync(Guid id);
    }
}
