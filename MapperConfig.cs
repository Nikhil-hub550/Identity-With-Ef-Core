using AutoMapper;
using StudentProject.DataAccess.Dtos;
using StudentProject.DataAccess.Model;

namespace StudentProject.DataAccess.ObjectMapper
{
    public partial class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<StudentDto, Student>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.StudentName))
                .ForMember(dest => dest.RollNo, opt => opt.MapFrom(src => src.StudentRollNo));
        }
    }
}
