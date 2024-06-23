﻿namespace Api.Dto;

public class CategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<CourseDto> Courses { get; set; }
}