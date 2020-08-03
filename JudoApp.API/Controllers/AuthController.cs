using Microsoft.AspNetCore.Mvc;
using JudoApp.API.Models;
using System.Threading.Tasks;
using JudoApp.API.Dtos;
using JudoApp.API.DAL;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

namespace JudoApp.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController: ControllerBase
    {
        private readonly IAuthRepository _repo;
         private readonly IConfiguration _config;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="config"></param>
        public AuthController(IAuthRepository repo,IConfiguration config)
        {
            _config = config;
            _repo = repo;
        }
      /// <summary>
      /// Metodo que registra un nuevo usuario
      /// </summary>
      /// <param name="UserForRegisterDto"></param>
      /// <returns></returns>
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto UserForRegisterDto)
        {
            UserForRegisterDto.Username = UserForRegisterDto.Username.ToLower();
            if(await _repo.UserExists(UserForRegisterDto.Username))
                    return  BadRequest("Este nombre de usuario ya esta registrado");
            var userToCreate = new User
            {
                UserName = UserForRegisterDto.Username
            };

            var createdUser = await _repo.Register(userToCreate,UserForRegisterDto.Password);
            return StatusCode(201);

            
        }
        /// <summary>
        /// procedimiento para hacer el login de un usuario al sistema
        /// </summary>
        /// <param name="userForLoginDto"></param>
        /// <returns></returns>
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var userFromRepo = await _repo.Login(userForLoginDto.username,userForLoginDto.password);
            if(userFromRepo == null )
                    return Unauthorized();

            var claims = new[] {
                new Claim(ClaimTypes.NameIdentifier,userFromRepo.id.ToString()),
                new Claim(ClaimTypes.Name,userFromRepo.UserName)

            };
            var key = new SymmetricSecurityKey(Encoding.UTF8
            .GetBytes(_config.GetSection("AppSettings:Token").Value));

            var creds =  new SigningCredentials(key,SecurityAlgorithms.HmacSha512Signature);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };
            var tokenHandler = new  JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return Ok(new {
                token = tokenHandler.WriteToken(token)
            });
            
        }
    }
}