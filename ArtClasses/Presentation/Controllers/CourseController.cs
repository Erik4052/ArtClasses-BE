using ArtClasses.Application.DTOs;
using ArtClasses.Application.Interfaces;
using ArtClasses.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ArtClasses.Presentation.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CourseController(ICourseService _courseService):ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetAllCourses()
        {
            var courses = await _courseService.GetAllCoursesAsync();
            return Ok(courses);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CourseDto>> GetCourseById(Guid id)
        {
            var course = await _courseService.GetCourseByIdAsync(id);
            return Ok(course);
        }

        [HttpPost]

        public async Task<ActionResult> AddCourse(CreateCourseDto courseDto)
        {
            await _courseService.AddCourseAsync(courseDto);
            return CreatedAtAction(nameof(AddCourse), new { id = courseDto.Title }, courseDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCourse(Guid userId, UpdateCourseDto courseDto)
        {
            if(userId != courseDto.Id) return BadRequest();
            await _courseService.UpdateCourseAsync(courseDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(Guid id)
        {
            await _courseService.DeleteCourseAsync(id);
            return NoContent();
        }
    }
}
