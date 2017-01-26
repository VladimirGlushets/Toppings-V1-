using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Topping.Domain.Extentions;
using Topping.Domain.Models;
using Topping.Domain.Repositories.Implementations;
using Topping.Web.Models;

namespace Topping.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _productRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();
        }

        public ActionResult Index()
        {
            return View(GetGroups());
        }

        public ActionResult Products(GroupEnum group)
        {
            return View(_productRepository.GetProductsForGroup(group));
        }

        public ActionResult Details(int id)
        {
            return View(_productRepository.GetProductBy(id));
        }

        private List<GroupViewModel> GetGroups()
        {
            var groups = new List<GroupViewModel>();

            foreach (GroupEnum group in Enum.GetValues(typeof(GroupEnum)))
            {
                groups.Add(new GroupViewModel
                {
                    GroupEnum = group,
                    Name = group.GetValue(),
                    Description = group.GetDescription(),
                    ImagePath = new Uri(Request.Url, Url.Content(group.GetImageName())).AbsoluteUri
                });
            }

            return groups;
        }
    }
}