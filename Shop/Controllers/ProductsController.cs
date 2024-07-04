using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
	public class ProductsController : Controller
	{
		
		public IActionResult Index()
		{
			return View();
		}

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckProduct(ProductModel product)
		{
			product.userId = DbObjects.currentUser.id;
			DbObjects.AddProduct(product);
			return Redirect("Index");
		}

        public IActionResult SelectedProduct(int id)
		{
			return View(id);
		}

        public IActionResult Cart(int id)
        {
			DbObjects.currentUser.favouriteProducts.Add(DbObjects.Products.First(c => c.id == id));
			DbObjects.db.SaveChanges();

            return View();
        }
    }
}
