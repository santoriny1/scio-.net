using BusinessLogic.Services;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Movies.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UsersService _usersService;

        public UsersController(UsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        [ActionName("Get Users")]
        public List<User> Get()
        {
            return _usersService.GetUsers();
        }

        [HttpPost]
        [ActionName("Add User")]
        public User Post([FromBody] UserSession session)
        {
            return _usersService.CreateUser(session);
        }
    }
}
