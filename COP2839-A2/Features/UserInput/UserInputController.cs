using Microsoft.AspNetCore.Mvc;

namespace COP2839_A2.Features.UserInput
{
	public class UserInputController : Controller
	{
		public IActionResult UserInput;
		
		
		public IActionResult InputForm()
		{
			return View();
		}
	}
}
