using TspuWeb.Models;

namespace TspuWeb.Repositories
{
    public interface IUserRepository
    {
        public List<User> GetData();
        public User? GetData(int id);
        public void Add(User user);
        public void Delete(int id);
        public void Edit(User id);

    }
}
