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
    public static class Repository
    {
        private static List<User> _users = new List<User>();
        private static int _nextId = 1;
        public static List<User> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
            }
        }

        public static List<User> GetData()
        {
            return _users;
        }

        public static User? GetData(int id)
        {
            foreach (User user in _users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }

        public static void Add(User user)
        {
            user.Id = _nextId;
            _nextId++;
            _users.Add(user);
        }

        public static void Delete(int id)
        {
            User userToDelete = GetData(id);
            if (userToDelete != null)
            {
                _users.Remove(userToDelete);
            }
        }

        public static void Edit(User user)
        {
            User userToEdit = GetData(user.Id);
            if (userToEdit != null)
            {
                userToEdit.UserName = user.UserName;
                userToEdit.Login = user.Login;
            }
        }
    }
}
