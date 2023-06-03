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

        public void Add(DbUser user)
        {
            dbContext.Users.Add(user);

            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var dbUser = GetData(id);
            if (dbUser != null)
            { 
               dbContext.Users.Remove(dbUser);

               dbContext.SaveChanges();

            }
        }

        public void Edit(DbUser user)
        {
            var dbUser = GetData(user.Id);
            if (dbUser != null)
            {
                dbUser.Name = user.Name;
                dbUser.Login = user.Login;

                dbContext.SaveChanges();
            }
        }

        public List<DbUser> GetData()
        {
            var usersInDataBase = dbContext.Users.ToList();
            return usersInDataBase;
        }

        public DbUser? GetData(int id)
        {
            var userInDb = dbContext.Users.FirstOrDefault(user => user.Id == id);
            if (userInDb == null)
            {
                return null;
            }

            return userInDb;
        }
    }
}
