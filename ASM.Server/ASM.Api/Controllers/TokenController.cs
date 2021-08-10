using ASM.Share.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using ASM.Share.Models.ViewModels;

namespace ASM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IKhachhangSvc _khachhangSvc;
        public IConfiguration _configuration;
        public TokenController(IConfiguration config, IKhachhangSvc khachhangSvc)
        {
            _khachhangSvc = khachhangSvc;
            _configuration = config;
        }

        /// <summary>
        /// Trả về token dùng để xác thực các request
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/token
        ///         {
        ///             "email":"minhtran@gmail.com",
        ///             "password":"1"
        ///         }
        /// </remarks>
        /// <param name="viewWebLogin"></param>
        /// <returns>Token to send request</returns>
        [HttpPost]
        public async Task<IActionResult> Post(ViewWebLogin viewWebLogin)
        {
            List<ViewToken> list = new List<ViewToken>();
            if (viewWebLogin != null && !string.IsNullOrEmpty(viewWebLogin.Email) && !string.IsNullOrEmpty(viewWebLogin.Password))
            {
                var khachhang = _khachhangSvc.Login(viewWebLogin);
                if (khachhang != null)
                {
                    if (khachhang != null)
                    {
                        var claims = new[]
                        {
                            new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),

                            new Claim("Id", khachhang.KhachhangID.ToString()), //
                            new Claim("FullName", khachhang.FullName),
                            new Claim("Email", khachhang.EmailAddress)
                        };
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                        var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                        var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"],
                            claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);
                        ViewToken viewToken = new ViewToken()
                        {
                            Token = new JwtSecurityTokenHandler().WriteToken(token),
                            KhachhangId = khachhang.KhachhangID
                        };

                        list.Add(viewToken);
                        return Ok(viewToken);
                    }
                    else
                        return BadRequest();
                }
                else
                    return BadRequest();
            }
            else
                return BadRequest(); 
        }
    }
}
