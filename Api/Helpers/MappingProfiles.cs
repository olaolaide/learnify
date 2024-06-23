using Api.Dto;
using AutoMapper;
using Entity;

namespace Api.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Course, CourseDto>()
            .ForMember(dto => dto.Category, o => o.MapFrom(source => source.Category.Name));
        CreateMap<Requirement, RequirementDto>();
        CreateMap<Learning, LearningDto>();
        CreateMap<Category, CategoryDto>();
        CreateMap<Category, CategoriesDto>();
    }
}