using TspuWeb.Models;

namespace TspuWeb.Repositories
{
    public interface IUserRepository
    {
        public List<User> GetData();
        public User? GetData(int id);

        public List<User> Add();
        public User? Add(int id);

        public void Delete(int id);
        public void Edit(User id);

    }
}
