﻿using System.ComponentModel.DataAnnotations;

namespace ArtClasses.Application.DTOs
{
    public class UpdateCourseDto:BaseCourseDto
    {
        public Guid Id { get; set; }

    }
}
