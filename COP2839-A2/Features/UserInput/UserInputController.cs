using Microsoft.AspNetCore.Mvc;

namespace COP2839_A2.Features.UserInput
{
	[Route("UserInput")]
	public class UserInputController : Controller
	{
		[HttpGet("InputForm")]
		public IActionResult InputForm()
		{
			return View("~/Features/UserInput/InputForm.cshtml");
		}
	}
}
