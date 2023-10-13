using Microsoft.AspNetCore.Mvc;

namespace MyWebAppTK.Controllers
{
	public class AboutUsController : Controller
	{
		public IActionResult About()
		{
			return View();
		}
	}
}
