using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TspuWeb.Models;

namespace TspuWeb.Contracts
{
    public class User
    {
        public User() { }

        public User(DbUser user)
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


