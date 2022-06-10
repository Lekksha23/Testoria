using AutoMapper;
using Testoria.Data.Entities;

namespace Testoria.Business.Configuration
{
    public class AutoMapperForDataLayer : Profile
    {
        public AutoMapperForDataLayer()
        {
            CreateMap<QuestionModel, Question>().ReverseMap();
        }
    }
}
