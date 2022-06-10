using AutoMapper;
using Testoria.Business.Helpers;
using Testoria.Data.Repositories;

namespace Testoria.Business.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;

        public QuestionService(IQuestionRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public async Task<QuestionModel> GetQuestionById(int id)
        {
            var question = await _questionRepository.GetQuestionById(id);
            ExceptionHelper.CheckIfEntityIsNull(id, question);
            return _mapper.Map<QuestionModel>(question);
        }
    }
}
