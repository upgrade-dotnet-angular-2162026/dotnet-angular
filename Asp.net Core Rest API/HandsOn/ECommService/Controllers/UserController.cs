using ECommService.DTOs;
using ECommService.Entities;
using ECommService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody]User user)
        {
            try
            {
                user.CreatedDate = DateTime.Now;
                await userRepository.Register(user);
                return Ok(user);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("SignIn")]
        public async Task<IActionResult> Validate(LoginDto loginDto)
        {
            try
            {
                var user = await userRepository.Validate(loginDto.Email,loginDto.Password);
                return Ok(user);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        public async Task<IActionResult> Edit(User user)
        {
            try
            {
                await userRepository.Update(user);
                return Ok(user);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
    }
}
