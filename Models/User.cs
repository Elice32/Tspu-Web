using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TspuWeb.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Login { get; set; }
    }

    public interface IUserRepository
    {
        public List<User> GetData();
        public User GetData(int id);
        public void Add(User id);
        public void Delete(int id);
        public void Edit(User id);
    }

    public class UsersRepositoryInMemory : IUserRepository
    {
        private readonly MemoryProvider memoryProvider;

        public UsersRepositoryInMemory(MemoryProvider memoryProvider)
        {
            this.memoryProvider = memoryProvider;
        }

        public List<User> GetData()
        {
            return memoryProvider.Users;
        }

        public User GetData(int id)
        {
            return memoryProvider.Users.Find(user => user.Id == id);
        }

        public void Add(User user)
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

        public void Edit(User user)
        {
            var oldUser = GetData(user.Id);

            if (oldUser != null)
            {
                oldUser.UserName = user.UserName;
                oldUser.Login = user.Login;
            }
        }
    }

    public class MemoryProvider
    {
        public List<User> Users { get; set; } = new List<User>();
    }
}
