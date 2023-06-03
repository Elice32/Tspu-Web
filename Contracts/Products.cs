
using Microsoft.EntityFrameworkCore;
using TspuWeb.Models;

namespace TspuWeb.Models
{
    public class Products
    {
        public Products() { }

        public Products(dbProducts product)
        {
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
            Price = product.Price;
            IsDeleted = product.IsDeleted;
        }

        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }

    }
}