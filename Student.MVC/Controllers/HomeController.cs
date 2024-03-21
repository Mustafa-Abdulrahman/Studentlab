using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Student.BL.AppCinfigure;
using Student.BL.Helpers;
using Student.MVC.Models;
using System.Diagnostics;
using System.Text.Json;

namespace Student.MVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IOptions<FileConfig> _FileConfig;
		private readonly IOptionsSnapshot<FileConfig> _FileConfigsnap;
		private readonly IUtilities _utilities;

		public HomeController(ILogger<HomeController> logger , IOptions<FileConfig> FileConfig, IOptionsSnapshot<FileConfig> FileConfigsnap, IUtilities utilities)
		{
			_logger = logger;
			_FileConfig = FileConfig;
			_FileConfigsnap = FileConfigsnap;
			_utilities = utilities;

        }

		public IActionResult Index()
		{
			ViewBag.Data= JsonSerializer.Serialize(_FileConfig);
			ViewBag.DataSnap= JsonSerializer.Serialize(_FileConfigsnap);
			ViewBag.DataSnapMentor= JsonSerializer.Serialize(_utilities);
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
