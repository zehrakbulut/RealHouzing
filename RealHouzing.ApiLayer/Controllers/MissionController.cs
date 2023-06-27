using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.MissionDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MissionController : ControllerBase
	{
		private readonly IMissionService _missionService;

		public MissionController(IMissionService missionService)
		{
			_missionService = missionService;
		}

		[HttpGet]
		public IActionResult MissionList()
		{
			var values=_missionService.TGetList();
			return Ok(values);
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteMission(int id)
		{
			var values = _missionService.TGetById(id);
			_missionService.TDelete(values);
			return Ok();
		}

		[HttpPost]
		public IActionResult AddMission(ResultMissionDto resultMissionDto)
		{
			Mission mission = new Mission()
			{
				Title = resultMissionDto.Title,
				Description = resultMissionDto.Description,
				Icon = resultMissionDto.Icon
			};
			_missionService.TInsert(mission);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateMission(Mission mission)
		{
			_missionService.TUpdate(mission);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetMission(int id)
		{
			var values= _missionService.TGetById(id);
			return Ok(values);
		}
	}
}
