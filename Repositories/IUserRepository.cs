using TspuWeb.Contracts;
using TspuWeb.Models;

namespace TspuWeb.Repositories
{
    public interface IUserRepository
    {
        public List<DbUser> GetData();
        public DbUser? GetData(int id);
        public void Add(DbUser user);
        public void Delete(int id);
        public void Edit(DbUser user);

    }
}
