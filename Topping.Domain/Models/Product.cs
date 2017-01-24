namespace Topping.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public string Price { get; set; }

        public GroupEnum Group { get; set; }
    }
}
