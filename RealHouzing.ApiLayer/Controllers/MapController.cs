using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.DtoLayer.MapDtos;
using RealHouzing.EntityLayer.Concrete;
using System.Xml.Linq;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MapController : ControllerBase
	{
		private readonly IMapService _mapService;

		public MapController(IMapService mapService)
		{
			_mapService = mapService;
		}

		[HttpGet]
		public IActionResult MapList()
		{
			var values = _mapService.TGetList();
			return Ok(values);
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteMap(int id)
		{
			var values=_mapService.TGetById(id);
			_mapService.TDelete(values);
			return Ok();
		}

		[HttpPost]
		public IActionResult AddMap(ResultMapDto resultMapDto)
		{
			Map map = new Map()
			{
				Name = resultMapDto.Name,
				MapUrl = resultMapDto.MapUrl
			};
			_mapService.TInsert(map);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateMap(Map map)
		{
			_mapService.TUpdate(map);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetJoin(int id)
		{
			var values = _mapService.TGetById(id);
			return Ok(values);
		}
	}
}
