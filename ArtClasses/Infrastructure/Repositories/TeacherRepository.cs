using ArtClasses.Application.Interfaces;
using ArtClasses.Data;
using ArtClasses.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArtClasses.Infrastructure.Repositories
{
    public class TeacherRepository(AppDbContext _context) : ITeacherRepository
    {
        public async Task AddAsync(Teacher teacher)
        {
            await _context.AddAsync(teacher);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            if(teacher is not null)
            {
                _context.Teachers.Remove(teacher);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Teacher>> GetAllAsync()
        {
            return await _context.Teachers.ToListAsync();
        }

        public async Task<Teacher> GetByIdAsync(Guid id)
        {
            return await _context.Teachers.FindAsync(id);
        }

        public async Task UpdateAsync(Teacher teacher)
        {
            _context.Teachers.Update(teacher);
            await _context.SaveChangesAsync();
        }
    }
}
