using Microsoft.EntityFrameworkCore;
using TspuWeb.Contracts;
using TspuWeb.Models;

namespace TspuWeb.Models
{
    public class DbUser
    {
        public DbUser() { }

        public DbUser(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Login = user.Login;
            Password = user.Password;
            Opisanie = user.Opisanie;
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Opisanie { get; set; }

    }
}