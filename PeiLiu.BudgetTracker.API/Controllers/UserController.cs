using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PeiLiu.BudgetTacker.Core.Models.Request;
using PeiLiu.BudgetTacker.Core.ServiceInterfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PeiLiu.BudgetTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/users
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();

            return Ok(users);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> AddUser([FromBody] UserRequestModel requestModel)
        {
            var user = await _userService.AddUser(requestModel);
            return Ok(user);
        }

        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> DeleteUser([FromBody] UserRequestModel requestModel)
        {
            await _userService.DeleteUser(requestModel);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var user = await _userService.GetUserById(id);

            return Ok(user);
        }

    }
}
