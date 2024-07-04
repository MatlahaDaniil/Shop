using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
	public class SavedController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
