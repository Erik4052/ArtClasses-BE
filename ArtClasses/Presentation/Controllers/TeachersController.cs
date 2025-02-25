using ArtClasses.Application.DTOs;
using ArtClasses.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArtClasses.Presentation.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TeachersController(ITeacherService _teacherService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeacherDto>>> GetAllTeachers()
        {
            var teachers = await _teacherService.GetAllTeachersAsync();
            if (teachers is not null)
            {
                return Ok(teachers);

            }
            else
            {
                return BadRequest("Teachers not found");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TeacherDto>> GetTeacherById(Guid id)
        {
            var teacher = await _teacherService.GetTeacherByIdAsync(id);
            if(teacher is not null)
            {
            return Ok(teacher);

            }
            else
            {
                return BadRequest("Teacher was not found");
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddTeacher(CreateTeacherDto teacherDto)
        {
            await _teacherService.AddTeacherAsync(teacherDto);
            return CreatedAtAction(nameof(AddTeacher), new { id = teacherDto.UserId }, teacherDto);
        }

    }
}
