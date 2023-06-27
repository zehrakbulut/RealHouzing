using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.QuestionDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class QuestionController : ControllerBase
	{
		private readonly IQuestionService _questionService;

		public QuestionController(IQuestionService questionService)
		{
			_questionService = questionService;
		}

		[HttpGet]
		public  IActionResult QuestionList()
		{
			var values=_questionService.TGetList();
			return Ok(values);
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteQuestion(int id)
		{
			var values=_questionService.TGetById(id);
			_questionService.TDelete(values);
			return Ok();
		}

		[HttpPost]
		public IActionResult AddQuestion(ResultQuestionDto resultQuestionDto)
		{
			Question question = new Question()
			{
				Title1 = resultQuestionDto.Title1,
				Title2 = resultQuestionDto.Title2,
				Description = resultQuestionDto.Description,
				ImageUrl = resultQuestionDto.ImageUrl
			};
			_questionService.TInsert(question);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateQuestion(Question question)
		{
			_questionService.TUpdate(question);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetQuestion(int id)
		{
			var values = _questionService.TGetById(id);
			return Ok(values);	
		}
	}
}
