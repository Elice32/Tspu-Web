using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TspuWeb.Models;

namespace TspuWeb.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {

        [HttpGet]
        public List<User> Get()
        {
            return Repository.GetData();
        }
        [HttpGet("{id}")]
        public User? Get(int id)
        {
            return Repository.GetData(id);
        }

        [HttpPost]
        public void Post([FromBody] User user)
        {
            Repository.Add(user);
        }

        [HttpPut("{id}")]
        public void Put([FromBody] User user)
        {
            Repository.Edit(user);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Repository.Delete(id);
        }
    }
}