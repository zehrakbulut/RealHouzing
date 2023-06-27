using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.BuyingDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BuyingController : ControllerBase
	{
		private readonly IBuyingService _buyingService;

		public BuyingController(IBuyingService buyingService)
		{
			_buyingService = buyingService;
		}

		[HttpGet]
		public IActionResult BuyingList()
		{
			var values=_buyingService.TGetList();
			return Ok(values);
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteBuying(int id)
		{
			var values = _buyingService.TGetById(id);
			_buyingService.TDelete(values);
			return Ok();
		}

		[HttpPost]
		public IActionResult AddBuying(ResultBuyingDto resultBuyingDto)
		{
			Buying buying = new Buying()
			{
				Title = resultBuyingDto.Title,
				ImageUrl = resultBuyingDto.ImageUrl
			};
			_buyingService.TInsert(buying);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateBuying(Buying buying)
		{
			_buyingService.TUpdate(buying);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetBuying(int id)
		{
			var values = _buyingService.TGetById(id);
			return  Ok(values);
		}
	}
}
