using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TspuWeb.Contracts;
using TspuWeb.Models;
using TspuWeb.Repositories;

namespace TspuWeb.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _userRepository.GetData();
            var usersContract = users.Select(dbUser => new User(dbUser)).ToList();
            return Ok(usersContract);
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var dbUser = _userRepository.GetData(id);

            if (dbUser == null)
            {
                return NotFound();
            }

            var userContract = new User(dbUser);
            return Ok(userContract);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            var dbUser = new DbUser(user);
            _userRepository.Add(dbUser);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateUser([FromBody] User user)
        {
            if (user == null || user.Id == 0)
            {
                return BadRequest();
            }

            var dbUser = new DbUser(user);
            _userRepository.Edit(dbUser);
            return Ok();
        }
    }
}