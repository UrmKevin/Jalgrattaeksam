using Jalgrattaeksam.Data;
using Jalgrattaeksam.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jalgrattaeksam.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<User> GetUsers()
        {
            var users = _context.User.ToList();
            return users;
        }
        [HttpPost("signin/{username}/{password}")]
        public ActionResult<User> SignIn(string username, string password)
        {
            var user = _context.User.SingleOrDefault(u => u.Username == username && u.Password == password);

            if (user == null)
            {
                return Unauthorized();
            }

            return Ok(user);
        }
    }
}
