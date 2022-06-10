using Testoria.Data.Entities;

namespace Testoria.Data.Repositories
{
    public interface IQuestionRepository
    {
        Task<Question> GetQuestionById(int id);
    }
}