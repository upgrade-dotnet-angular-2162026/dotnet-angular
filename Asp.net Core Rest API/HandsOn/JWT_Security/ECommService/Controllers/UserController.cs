using ECommService.DTOs;
using ECommService.Entities;
using ECommService.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ECommService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        private IConfiguration _config;

        public UserController(IUserRepository userRepository, IConfiguration config)
        {
            this.userRepository = userRepository;
            _config = config;
        }
        [HttpPost("Register")]
        [AllowAnonymous] //any user can access
        public async Task<IActionResult> Register([FromBody] UserCreateDto userdto)
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
        [AllowAnonymous]
        public async Task<IActionResult> Validate(LoginDto loginDto)
        {
            try
            {
                var user = await userRepository.Validate(loginDto.Email, loginDto.Password);
                UserReadDto userReadDto = new UserReadDto();
                if (user != null)
                {
                    //converting user entity to userReadDto
                    userReadDto = new UserReadDto()
                    {
                        UserId = user.UserId,
                        Name = user.Name,
                        Role = user.Role,
                        Token = GenerateToken(user)
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
        [Authorize(Roles ="Customer")]
        public async Task<IActionResult> Edit(UserUpdateDto userUpdate)
        {
            try
            {
                //converting dto to user entity
                var user = new User()
                {
                    Email = userUpdate.Email,
                    Mobile = userUpdate.Mobile,
                    UserId = userUpdate.UserId,
                    Name = userUpdate.Name,
                };

                await userRepository.Update(user);
                return Ok(user);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        private string GenerateToken(User user)
        {
            //generating key
            var key = new SymmetricSecurityKey(
Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            //define claims(payloads)
            var claims = new[]
{
new Claim(ClaimTypes.Name, user.Name),
new Claim(ClaimTypes.Role, user.Role)
};
            //token generation
            var token = new JwtSecurityToken(
issuer: _config["Jwt:Issuer"],
audience: _config["Jwt:Audience"],
claims: claims,
expires: System.DateTime.Now.AddMinutes(Convert.ToDouble(_config["Jwt:ExpiryMinutes"])),
signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
);
            //convert token object to string
            string generatedToken = new JwtSecurityTokenHandler().WriteToken(token).ToString();
            return generatedToken;
        }
    }
}
