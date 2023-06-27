﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.ProgressDtos;
using RealHouzing.DtoLayer.RegisterPropertyDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RegisterPropertyController : ControllerBase
	{
		private readonly IRegisterPropertyService _registerPropertyService;

		public RegisterPropertyController(IRegisterPropertyService registerPropertyService)
		{
			_registerPropertyService = registerPropertyService;
		}

		[HttpGet]
		public IActionResult RegisterPropertyList()
		{
			var values=_registerPropertyService.TGetList();
			return Ok(values);
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteRegisterProperty(int id)
		{
			var values=_registerPropertyService.TGetById(id);
			_registerPropertyService.TDelete(values);
			return Ok();
		}

		[HttpPost]
		public IActionResult AddRegisterProperty(ResultRegisterPropertyDto resultRegisterPropertyDto)
		{
			RegisterProperty registerProperty = new RegisterProperty()
			{
				Title1 = resultRegisterPropertyDto.Title1,
				Title2 = resultRegisterPropertyDto.Title2,
				Description = resultRegisterPropertyDto.Description,
				ImageUrl = resultRegisterPropertyDto.ImageUrl
			};
			_registerPropertyService.TInsert(registerProperty);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateRegisterProperty(RegisterProperty registerProperty)
		{
			_registerPropertyService.TUpdate(registerProperty);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetRegisterProperty(int id)
		{
			var values = _registerPropertyService.TGetById(id);
			return Ok(values);
		}
	}
}
