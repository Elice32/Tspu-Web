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
}
