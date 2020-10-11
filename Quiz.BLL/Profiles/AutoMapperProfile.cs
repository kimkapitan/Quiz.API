using AutoMapper;
using Quiz.BLL.DTOs;
using Quiz.DAL.Entities;

namespace Quiz.BLL.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Question, QuestionDto>().ReverseMap();
        }
    }
}
