using ArtClasses.Application.Interfaces;
using ArtClasses.Data;
using ArtClasses.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArtClasses.Infrastructure.Repositories
{
    public class CourseRepository(AppDbContext _context) : ICourseRepository
    {

        async Task ICourseRepository.AddAsync(Course course)
        {   
          await _context.Courses.AddAsync(course);
          await _context.SaveChangesAsync();
        }

        async Task ICourseRepository.DeleteAsync(Guid id)
        {
           var course = await _context.Courses.FindAsync(id);
            if(course != null)
            {
                _context.Courses.Remove(course);
                await _context.SaveChangesAsync(true);
            }
        }

        async Task<IEnumerable<Course>> ICourseRepository.GetAllAsync()
        {
            return await _context.Courses.ToListAsync();
        }

        async Task<Course> ICourseRepository.GetByIdAsync(Guid id)
        {
            return await _context.Courses.FindAsync(id);
        }

        async Task ICourseRepository.UpdateAsync(Course course)
        {
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();
        }
    }
}
