using AutoMapper;
using Testoria.API.Models;
using Testoria.Business;

namespace Testoria.API.Configuration
{
    public class AutoMapperApi : Profile
    {
        public AutoMapperApi()
        {
            CreateMap<QuestionModel, QuestionResponse>();
        }
    }
}
