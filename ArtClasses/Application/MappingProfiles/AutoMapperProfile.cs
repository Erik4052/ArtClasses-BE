using ArtClasses.Application.DTOs;
using ArtClasses.Domain.Entities;
using AutoMapper;
namespace ArtClasses.Application.MappingProfiles
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() 
        {
            // Map Entity -> DTO
            CreateMap<Course, CourseDto>();

            // Map DTO -> Entity
            CreateMap<CreateCourseDto, Course>();
            CreateMap<UpdateCourseDto, Course>();

        
        }  
    }
}
