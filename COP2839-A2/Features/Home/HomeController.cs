using System.Diagnostics;
using COP2839_A2.Models;
using Microsoft.AspNetCore.Mvc;

namespace COP2839_A2.Features.Home
{
	
	public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

		[HttpGet("")]
		[HttpGet("Index")]
		public IActionResult Index()
        {
			return View(); 
        }

        [HttpGet("Privacy")]
		public IActionResult Privacy()
        {
            return View("~/Features/Home/Privacy.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
