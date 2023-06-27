﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.NewsDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NewsController : ControllerBase
	{
		private readonly INewsService  _newsService;

		public NewsController(INewsService newsService)
		{
			_newsService = newsService;
		}

		[HttpGet]
		public IActionResult NewsList()
		{
			var values=_newsService.TGetList();
			return Ok(values);
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteNews(int id)
		{
			var values=_newsService.TGetById(id);
			_newsService.TDelete(values);
			return Ok();
		}

		[HttpPost]
		public IActionResult AddNews(ResultNewsDto resultNewsDto)
		{
			News news = new News()
			{
				NameSurname = resultNewsDto.NameSurname,
				Date = resultNewsDto.Date,
				Title = resultNewsDto.Title,
				Description = resultNewsDto.Description,
				ImageUrl = resultNewsDto.ImageUrl,
				ProfileImage = resultNewsDto.ProfileImage
			};
			_newsService.TInsert(news);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateNews(News news)
		{
			_newsService.TUpdate(news);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetNews(int id)
		{
			var values = _newsService.TGetById(id);
			return Ok(values);
		}
	}
}
