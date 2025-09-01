using COP2839_A2.Interfaces;
using COP2839_A2.Models;
using Microsoft.AspNetCore.Mvc;
namespace COP2839_A2.Controllers
{
	public class VFRWxController : Controller
	{
		private readonly IVFRWxService _vfrwxservice;

		public VFRWxController(IVFRWxService vfrwxservice)
		{
			_vfrwxservice = vfrwxservice;
		}


		[HttpGet]
		public IActionResult CheckVFR
			(
			int belowClouds,
			int aboveClouds,
			int horizontalCloudSeparation,
			int visibility
			)
		{
			bool isVFR = _vfrwxservice.IsVFR
				(
				belowClouds,
				aboveClouds,
				horizontalCloudSeparation,
				visibility
				);

			var model = new VFRWxInputModel
			{
				BelowClouds = belowClouds,
				AboveClouds = aboveClouds,
				HorizontalCloudSeparation = horizontalCloudSeparation,
				Visibility = visibility,
				IsVFR = isVFR
			};
			return View(isVFR);
		}
	}
}
