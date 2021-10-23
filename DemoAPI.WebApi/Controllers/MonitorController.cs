using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.WebApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class MonitorController : ControllerBase
	{
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "val-1", "val-2" };
		}
	}
}
