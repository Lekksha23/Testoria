using AutoMapper;
using Testoria.Data.Entities;

namespace Testoria.Business.Configuration
{
    public class AutoMapperData : Profile
    {
        public AutoMapperData()
        {
            CreateMap<QuestionModel, Question>().ReverseMap();
        }
    }
}
