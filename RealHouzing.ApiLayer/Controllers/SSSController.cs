using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;

namespace RealHouzing.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SSSController : ControllerBase
	{
		private readonly ISSSService _sSSService;

		public SSSController(ISSSService sSSService)
		{
			_sSSService = sSSService;
		}

		[HttpGet]
	}
}
