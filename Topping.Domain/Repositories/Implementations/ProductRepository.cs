using System.Collections.Generic;
using System.Linq;
using Topping.Domain.Models;
using Topping.Domain.Repositories.Interfaces;
using Topping.Domain.Store;

namespace Topping.Domain.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductStore _productStore;

        public ProductRepository()
        {
            _productStore = new ProductStore();
        }

        public List<Product> GetAllProducts()
        {
            return _productStore.Products;
        }

        public List<Product> GetProductsForGroup(GroupEnum group)
        {
            return _productStore.Products.Where(x => x.Group == group).ToList();
        }

        public Product GetProductBy(int id)
        {
            return _productStore.Products.FirstOrDefault(x => x.Id == id);
        }

        public Product GetProductBy(string name)
        {
            return _productStore.Products.FirstOrDefault(x => x.Name == name);
        }
    }
}
