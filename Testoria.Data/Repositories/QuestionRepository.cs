using Dapper;
using System.Data;
using Testoria.Data.Entities;
using Testoria.Data.Configuration;
using Microsoft.Extensions.Options;

namespace Testoria.Data.Repositories
{
    public class QuestionRepository : BaseRepository, IQuestionRepository
    {
        private const string _getQuestionByIdProcedure = "dbo.Question_SelectById";

        public QuestionRepository(IOptions<DbConfiguration> options) : base(options)
        {

        }

        public async Task<Question> GetQuestionById(int id)
        {
            using IDbConnection connection = ProvideConnection();

            var resource = await connection.QueryFirstOrDefaultAsync<Question>(
                _getQuestionByIdProcedure,
                new { Id = id },
                commandType: CommandType.StoredProcedure);

            return resource;
        }
    }
}
