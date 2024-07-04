
using Shop.Models;
using Microsoft.EntityFrameworkCore;

namespace Shop.Repository
{
    public class ProductRepository
    {
        private readonly AppDbContent appDbContent;

        public ProductRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<ProductModel> Products => appDbContent.product.Include(c => c.name);

        public ProductModel GetProduct(int productId) => appDbContent.product.FirstOrDefault(c => c.id == productId);
    }
}
