
namespace Testoria.Business.Services
{
    public interface IQuestionService
    {
        Task<QuestionModel> GetQuestionById(int id);
    }
}