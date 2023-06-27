using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.CommercialDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CommercialController : ControllerBase
	{
		private readonly ICommercialService _commercialService;

		public CommercialController(ICommercialService commercialService)
		{
			_commercialService = commercialService;
		}

		[HttpGet]
		public IActionResult CommercialList()
		{
			var values = _commercialService.TGetList();
			return Ok(values);
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteCommercial(int id)
		{
			var values=_commercialService.TGetById(id);
			_commercialService.TDelete(values);
			return Ok();
		}

		[HttpPost]
		public IActionResult AddCommercial(ResultCommercialDto resultCommercialDto)
		{
			Commercial commercial = new Commercial()
			{
				Title = resultCommercialDto.Title,
				ImageUrl = resultCommercialDto.ImageUrl
			};
			_commercialService.TInsert(commercial);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateCommercial(Commercial commercial)
		{
			_commercialService.TUpdate(commercial);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetCommercial(int id)
		{
			var values = _commercialService.TGetById(id);
			return Ok(values);
		}
	}
}
 