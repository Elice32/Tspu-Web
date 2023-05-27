using Microsoft.EntityFrameworkCore;
using TspuWeb.Models;

namespace TspuWeb.Repositories
{
    public class UserRepositoryInDataBase : IUserRepository
    {
        private readonly ApplicationDbContext dbContext;

        public UserRepositoryInDataBase(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(User user)
        {
            var dbUser = new DbUser(user);
            dbContext.Users.Add(dbUser);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(User id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetData()
        {
            var usersInDataBase = dbContext.Users.ToList();
            return usersInDataBase.Select(user => new User(user)).ToList();
        }

        public User? GetData(int id)
        {
            var userInDb = dbContext.Users.FirstOrDefault(user => user.Id == id);
            if (userInDb == null)
            {
                return null;
            }

            return new User(userInDb);
        }
    }
}
