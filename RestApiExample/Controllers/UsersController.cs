// Controllers/UsersController.cs
using Microsoft.AspNetCore.Mvc;
using RestApiExample.Models;
using System.Collections.Generic;

namespace RestApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // Static list of users for the demonstration
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Christian", Email = "christian@example.com" },
            new User { Id = 2, Name = "Viviana", Email = "viviana@example.com" },
            new User { Id = 3, Name = "Pepito", Email = "pepito@example.com" },
            new User { Id = 4, Name = "Juanito", Email = "juanito@example.com" }
        };

        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return Ok(users); // Returns the list of users
        }

        // GET api/users/1
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = users.Find(u => u.Id == id);
            if (user == null)
            {
                return NotFound(); // If the user does not exist, it returns a 404 error.
            }
            return Ok(user); // If it exists, returns the user
        }
    }
}
