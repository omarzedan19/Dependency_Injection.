using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test_project.Controllers.models;

namespace test_project.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        Iuser Myusers = null;

        public UserController(Iuser firstuser)
        {
            Myusers = firstuser;
        }


        [HttpPost]
        public void Adduser( [FromBody] User user)
        {
            Myusers.Adduser(user);
        }

        [HttpDelete("{id}")]
        public void Deleteuser(int id)
        {
            Myusers.Deleteuser(id);

        }

        [HttpGet]
        public List<User> GetAllUsers()
        {
          return  Myusers.GetAllUsers();
        }

        [HttpGet("{id}")]
        public User GetUser(int id)
        {
            return Myusers.GetUser(id);
        }
    }

}
