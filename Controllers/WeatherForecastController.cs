using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TspuWeb.Models;



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
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _userRepository.GetData(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            _userRepository.Add(user);
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        [HttpPut]
        public IActionResult UpdateUser([FromBody] User user)
        {
            if (user == null || user.Id == 0)
            {
                return BadRequest();
            }

            _userRepository.Edit(user);
            return NoContent();
        }
    }
}