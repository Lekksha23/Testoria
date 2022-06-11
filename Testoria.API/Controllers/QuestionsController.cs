using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Testoria.API.Models;
using Testoria.Business.Services;

namespace Testoria.API.Controllers
{
    [ApiController]
    [Route("api/questions")]
    public class QuestionsController : Controller
    {
        private readonly IQuestionService _questionService;
        private readonly IMapper _mapper;

        public QuestionsController(IQuestionService questionService, IMapper mapper)
        {
            _questionService = questionService;
            _mapper = mapper;
        }

        //api/questions/
        [HttpGet("id")]
        [SwaggerOperation("Get question by id (Now works only with id = 4)")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [SwaggerResponse(StatusCodes.Status200OK, "Successful", typeof(QuestionResponse))]
        public async Task<ActionResult<QuestionResponse>> GetQuestionById([FromQuery] int id)
        {
            var question = await _questionService.GetQuestionById(id);
            var result = _mapper.Map<QuestionResponse>(question);
            return Ok(result);
        }
    }
}
