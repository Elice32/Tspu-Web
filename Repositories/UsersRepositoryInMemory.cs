using TspuWeb.Contracts;
using TspuWeb.Models;

namespace TspuWeb.Repositories
{
    public class UsersRepositoryInMemory : IUserRepository
    {
        private readonly MemoryProvider memoryProvider;

        public UsersRepositoryInMemory(MemoryProvider memoryProvider)
        {
            this.memoryProvider = memoryProvider;
        }

        public List<DbUser> GetData()
        {
            return memoryProvider.Users;
        }

        public DbUser GetData(int id)
        {
            return memoryProvider.Users.FirstOrDefault(user => user.Id == id);
        }

        public void Add(DbUser user)
        {
            if (memoryProvider.Users.Count == 0)
            {
                user.Id = 1;
            }
            else
            {
                user.Id = memoryProvider.Users.Max(user => user.Id) + 1;
            }
            memoryProvider.Users.Add(user);
        }

        public void Delete(int id)
        {
            var user = GetData(id);
            if (user != null)
            {
                memoryProvider.Users.Remove(user);
            }
        }

        public void Edit(DbUser user)
        {
            var oldUser = GetData(user.Id);

            if (oldUser != null)
            {
                oldUser.Name = user.Name;
                oldUser.Login = user.Login;
            }
        }
    }
}
