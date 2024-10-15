using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RhApi.Application.IServices;
using RhApi.Domain;
using RhApi.Infrastructure;

namespace RhApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUsuario([FromBody] User user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _userService.Add(user);
            return CreatedAtAction(nameof(CreateUsuario), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUsuario(int id, [FromBody] User user)
        {
            if (id != user.Id || !ModelState.IsValid)
                return BadRequest();

            await _userService.Update(id, user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
       {
            await _userService.Remove(id);
            return NoContent();
        }


    }
}
