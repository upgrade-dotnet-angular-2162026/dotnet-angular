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
        public async Task<IActionResult> Register([FromBody]UserCreateDto userdto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //converting userDto data to User entity
                    var user = new User()
                    {
                        Name = userdto.Name,
                        Email = userdto.Email,
                        Mobile = userdto.Mobile,
                        Role = userdto.Role,
                        Password = userdto.Password,
                        CreatedDate = DateTime.Now,
                    };

                    await userRepository.Register(user);
                    return Ok(user);
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null)
                        return StatusCode(500, ex.InnerException.Message);
                    else
                        return StatusCode(500, ex.Message);
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        [HttpPost("SignIn")]
        public async Task<IActionResult> Validate(LoginDto loginDto)
        {
            try
            {
                var user = await userRepository.Validate(loginDto.Email,loginDto.Password);
                UserReadDto userReadDto = new UserReadDto();
                if (user != null)
                {
                    //converting user entity to userReadDto
                     userReadDto = new UserReadDto()
                    {
                        UserId = user.UserId,
                        Name = user.Name,
                        Role = user.Role
                    };
                   
                }
                return Ok(userReadDto);

            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut("Edit")]
        public async Task<IActionResult> Edit(UserUpdateDto userUpdate)
        {
            try
            {
                //converting dto to user entity
                var user = new User()
                { 
                    Email=userUpdate.Email,
                    Mobile=userUpdate.Mobile,
                    UserId=userUpdate.UserId,
                    Name=userUpdate.Name,
                };

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
