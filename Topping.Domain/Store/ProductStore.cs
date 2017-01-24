using System.Collections.Generic;
using Topping.Domain.Models;

namespace Topping.Domain.Store
{
    public class ProductStore
    {
        public ProductStore()
        {
            Products = new List<Product>();
            InitBerryProducts();
            InitFruitProducts();
            InitCocktailProducts();
            InitCoffeeProducts();
        }

        public List<Product> Products { get; set; }

        private void InitBerryProducts()
        {
            Products.AddRange(new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Arabic Coffee",
                    ShortDescription = "Очень вкусно",
                    Description = "Прям совсем вкусно",
                    Group = GroupEnum.Berry,
                    Price = string.Empty,
                    ImagePath = ""
                },
                new Product
                {
                    Id = 2,
                    Name = "Arabic Coffee 2",
                    ShortDescription = "Очень вкусно",
                    Description = "Прям совсем вкусно",
                    Group = GroupEnum.Berry,
                    Price = string.Empty,
                    ImagePath = ""
                },
                new Product
                {
                    Id = 3,
                    Name = "Arabic Coffee 3",
                    ShortDescription = "Очень вкусно",
                    Description = "Прям совсем вкусно",
                    Group = GroupEnum.Berry,
                    Price = string.Empty,
                    ImagePath = ""
                }
            });
        }

        private void InitCoffeeProducts()
        {
            Products.AddRange(new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Arabic Coffee",
                    ShortDescription = "Очень вкусно",
                    Description = "Прям совсем вкусно",
                    Group = GroupEnum.Coffee,
                    Price = string.Empty,
                    ImagePath = ""
                },
                new Product
                {
                    Id = 2,
                    Name = "Arabic Coffee 2",
                    ShortDescription = "Очень вкусно",
                    Description = "Прям совсем вкусно",
                    Group = GroupEnum.Coffee,
                    Price = string.Empty,
                    ImagePath = ""
                },
                new Product
                {
                    Id = 3,
                    Name = "Arabic Coffee 3",
                    ShortDescription = "Очень вкусно",
                    Description = "Прям совсем вкусно",
                    Group = GroupEnum.Coffee,
                    Price = string.Empty,
                    ImagePath = ""
                }
            });
        }

        private void InitCocktailProducts()
        {
            Products.AddRange(new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Arabic Coffee",
                    ShortDescription = "Очень вкусно",
                    Description = "Прям совсем вкусно",
                    Group = GroupEnum.Cocktail,
                    Price = string.Empty,
                    ImagePath = ""
                },
                new Product
                {
                    Id = 2,
                    Name = "Arabic Coffee 2",
                    ShortDescription = "Очень вкусно",
                    Description = "Прям совсем вкусно",
                    Group = GroupEnum.Cocktail,
                    Price = string.Empty,
                    ImagePath = ""
                },
                new Product
                {
                    Id = 3,
                    Name = "Arabic Coffee 3",
                    ShortDescription = "Очень вкусно",
                    Description = "Прям совсем вкусно",
                    Group = GroupEnum.Cocktail,
                    Price = string.Empty,
                    ImagePath = ""
                }
            });
        }

        private void InitFruitProducts()
        {
            Products.AddRange(new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Arabic Coffee",
                    ShortDescription = "Очень вкусно",
                    Description = "Прям совсем вкусно",
                    Group = GroupEnum.Fruit,
                    Price = string.Empty,
                    ImagePath = ""
                },
                new Product
                {
                    Id = 2,
                    Name = "Arabic Coffee 2",
                    ShortDescription = "Очень вкусно",
                    Description = "Прям совсем вкусно",
                    Group = GroupEnum.Fruit,
                    Price = string.Empty,
                    ImagePath = ""
                },
                new Product
                {
                    Id = 3,
                    Name = "Arabic Coffee 3",
                    ShortDescription = "Очень вкусно",
                    Description = "Прям совсем вкусно",
                    Group = GroupEnum.Fruit,
                    Price = string.Empty,
                    ImagePath = ""
                }
            });
        }
    }
}
