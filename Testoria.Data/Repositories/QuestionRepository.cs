using Microsoft.EntityFrameworkCore;
using Testoria.Data.Entities;

namespace Testoria.Data.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly TestoriaContext _context;

        public QuestionRepository(TestoriaContext context)
        {
            _context = context;
        }

        public async Task<Question?> GetQuestionById(int id)
            => await _context.Questions.FirstOrDefaultAsync(g => g.Id == id);
    }
}
