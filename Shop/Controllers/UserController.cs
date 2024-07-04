using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
	public class UserController : Controller
	{
		public ActionResult LogIn()
		{
			return View();
		}

		public ActionResult Registration()
		{
			return View();
		}

		[HttpPost]
		public ActionResult CheckRegistration(UserModel newUser) 
		{
			if (DbObjects.Users != null)
			{
				foreach (var item in DbObjects.Users)
				{
					if (item.email == newUser.email && item.password == newUser.password)
					{
						return Redirect("ErrorPage");
					}

				}
			}
			DbObjects.AddUser(newUser);
            DbObjects.currentUser = newUser;
            return Redirect("/");
		}

        [HttpPost]
        public ActionResult CheckAuthorization(UserModel user)
        {
            foreach (var item in DbObjects.Users)
            {
                if (item.email == user.email && item.password == user.password)
                {
					DbObjects.currentUser = item;
                    return Redirect("/");
                }

            }
			return Redirect("ErrorPage");
        }

		public ActionResult LogOut()
		{
			DbObjects.currentUser = null;
			return Redirect("/");
		}

        public ActionResult ErrorPage()
		{
			return View();
		}

		//// GET: UserController/Details/5
		//public ActionResult Details(int id)
		//{
		//	return View();
		//}

		//// GET: UserController/Create
		//public ActionResult Create()
		//{
		//	return View();
		//}

		//// POST: UserController/Create
		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public ActionResult Create(IFormCollection collection)
		//{
		//	try
		//	{
		//		return RedirectToAction(nameof(Index));
		//	}
		//	catch
		//	{
		//		return View();
		//	}
		//}

		//// GET: UserController/Edit/5
		//public ActionResult Edit(int id)
		//{
		//	return View();
		//}

		//// POST: UserController/Edit/5
		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public ActionResult Edit(int id, IFormCollection collection)
		//{
		//	try
		//	{
		//		return RedirectToAction(nameof(Index));
		//	}
		//	catch
		//	{
		//		return View();
		//	}
		//}

		//// GET: UserController/Delete/5
		//public ActionResult Delete(int id)
		//{
		//	return View();
		//}

		//// POST: UserController/Delete/5
		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public ActionResult Delete(int id, IFormCollection collection)
		//{
		//	try
		//	{
		//		return RedirectToAction(nameof(Index));
		//	}
		//	catch
		//	{
		//		return View();
		//	}
		//}
	}
}
