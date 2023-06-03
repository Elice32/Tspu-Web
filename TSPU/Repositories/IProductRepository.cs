using TspuWeb.Models;

namespace TspuWeb.Repositories
{
    public interface IProductRepository
    {
        public List<dbProducts> GetDataProduct();
        public dbProducts? GetDataProduct(int id);
        public void AddProduct(dbProducts product);
        public void DeleteProduct(int id);
        public void EditProduct(dbProducts product);

    }
}