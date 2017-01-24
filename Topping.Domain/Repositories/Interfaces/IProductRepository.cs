using System.Collections.Generic;
using Topping.Domain.Models;

namespace Topping.Domain.Repositories.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();

        List<Product> GetProductsForGroup(GroupEnum group);

        Product GetProductBy(int id);

        Product GetProductBy(string name);
    }
}
