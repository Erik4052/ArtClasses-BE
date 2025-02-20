﻿namespace ArtClasses.Application.DTOs
{
    public class CourseDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Guid TeacherId { get; set; }
        public string Category { get; set; }
        public string Thumbnail { get; set; }
    }
}
