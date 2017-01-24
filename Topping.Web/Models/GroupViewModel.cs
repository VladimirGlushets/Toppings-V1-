using Topping.Domain.Models;

namespace Topping.Web.Models
{
    public class GroupViewModel
    {
        public GroupEnum GroupEnum { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }
    }
}
