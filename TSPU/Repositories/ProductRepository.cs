using Microsoft.EntityFrameworkCore.Infrastructure;
using TspuWeb.Models;

namespace TspuWeb.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddProduct(dbProducts product)
        {
            dbContext.dbProducts.Add(product);

            dbContext.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var dbProducts = GetDataProduct(id);
            if (dbProducts != null)
            {
                dbContext.dbProducts.Remove(dbProducts);

                dbContext.SaveChanges();

            }
        }

        public void EditProduct(dbProducts product)
        {
            var dbProducts = GetDataProduct(product.Id);
            if (dbProducts != null)
            {
                dbProducts.Name = product.Name;

                dbContext.SaveChanges();
            }
        }

        public List<dbProducts> GetDataProduct()
        {
            var productInDb = dbContext.dbProducts.ToList();
            return productInDb;
        }

        public dbProducts? GetDataProduct(int id)
        {
            var productInDb = dbContext.dbProducts.FirstOrDefault(product => product.Id == id);
            if (productInDb == null)
            {
                return null;
            }

            return productInDb;
        }
    }
}
