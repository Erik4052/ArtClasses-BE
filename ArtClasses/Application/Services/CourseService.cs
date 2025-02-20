using ArtClasses.Application.DTOs;
using ArtClasses.Application.Interfaces;
using ArtClasses.Domain.Entities;
using AutoMapper;

namespace ArtClasses.Application.Services
{
    public class CourseService(ICourseRepository _courseRepository, IMapper _mapper) : ICourseService
    {
        public async Task AddCourseAsync(CreateCourseDto courseDto)
        {
                var course = _mapper.Map<Course>(courseDto);
                await _courseRepository.AddAsync(course);
        }

        public async Task DeleteCourseAsync(Guid id)
        {
            await _courseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CourseDto>> GetAllCoursesAsync()
        {
            var courses = await _courseRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CourseDto>>(courses);    
        }

        public async Task<CourseDto> GetCourseByIdAsync(Guid id)
        {
            var course = await _courseRepository.GetByIdAsync(id);
            return _mapper.Map<CourseDto>(course);
        }

        public async Task UpdateCourseAsync(UpdateCourseDto courseDto)
        {
            var course = _mapper.Map<Course>(courseDto);
            await _courseRepository.UpdateAsync(course);
        }
    }
}
