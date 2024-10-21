using Microsoft.AspNetCore.Mvc;

namespace testing.Controllers
{
	public class demoController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
