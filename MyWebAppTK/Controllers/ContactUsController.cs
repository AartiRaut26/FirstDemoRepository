using Microsoft.AspNetCore.Mvc;

namespace MyWebAppTK.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
