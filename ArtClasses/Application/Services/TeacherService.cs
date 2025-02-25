using ArtClasses.Application.DTOs;
using ArtClasses.Application.Interfaces;
using ArtClasses.Domain.Entities;
using AutoMapper;

namespace ArtClasses.Application.Services
{
    public class TeacherService(ITeacherRepository _teacherRepository, IMapper _mapper) : ITeacherService

    {
        public  async Task AddTeacherAsync(CreateTeacherDto teacherDto)
        {
            var teacher = _mapper.Map<Teacher>(teacherDto);
            await _teacherRepository.AddAsync(teacher);
        }

        public  async Task DeleteTeacherAsync(Guid id)
        {
            await _teacherRepository.DeleteAsync(id);
        }

        public  async Task<IEnumerable<TeacherDto>> GetAllTeachersAsync()
        {
            var teachers = await _teacherRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<TeacherDto>>(teachers);
        }

        public async Task<TeacherDto> GetTeacherByIdAsync(Guid id)
        {
            var teacher = await _teacherRepository.GetByIdAsync(id);
            return _mapper.Map<TeacherDto>(teacher);
        }

        public async Task UpdateTeacherAsync(UpdateTeacherDto teacherDto)
        {
            var teacher = _mapper.Map<Teacher>(teacherDto);
            await _teacherRepository.UpdateAsync(teacher);
        }
    }
}
