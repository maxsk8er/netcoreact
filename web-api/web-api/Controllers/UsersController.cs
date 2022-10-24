using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web_api.Controllers
{
    [Route("api/users")]
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new[]
            {
                new { Name = "Renato" },
                new { Name = "Sandra" }

            };

            return Ok(users);
        }
        
    }
}

