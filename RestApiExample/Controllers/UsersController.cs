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
        // Lista estática de usuarios para la demostración
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Christian", Email = "christian@example.com" },
            new User { Id = 2, Name = "Viviana", Email = "viviana@example.com" },
            new User { Id = 3, Name = "Pepito", Email = "pepito@example.com" }
            new User { Id = 4, Name = "Juanito", Email = "juanito@example.com" }
        };

        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return Ok(users); // Devuelve la lista de usuarios
        }

        // GET api/users/1
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = users.Find(u => u.Id == id);
            if (user == null)
            {
                return NotFound(); // Si el usuario no existe, devuelve un error 404
            }
            return Ok(user); // Si existe, devuelve el usuario
        }
    }
}
