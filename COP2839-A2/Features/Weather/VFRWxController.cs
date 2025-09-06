using COP2839_A2.Features.UserInput;
using COP2839_A2.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace COP2839_A2.Features.Weather
{
	[Route("VFRWx")]
	public class VFRWxController : Controller
	{
		private readonly IVFRWxService _vfrwxservice;

		public VFRWxController(IVFRWxService vfrwxservice)
		{
			_vfrwxservice = vfrwxservice;
		}

		[HttpGet("CheckVFR")]
		public IActionResult CheckVFR(VFRWxInputModel model)
		{
			bool isVFR = _vfrwxservice.IsVFR
				(
				model.BelowClouds,
				model.AboveClouds,
				model.HorizontalCloudSeparation,
				model.Visibility
				);
				return View("~/Features/Weather/CheckVFR.cshtml", isVFR);
		}
	}
}
