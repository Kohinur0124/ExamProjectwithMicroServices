using AuthApiExam.Model;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using StackExchange.Redis;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthApiExam.Services
{
    public class TokenGenerator
    {
       

        

        public async ValueTask<string> TGeneratorAsync(DtoLogin loginDTO)
        {
           
                if(FunctionforTests.isFoundUser(loginDTO))
                {
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("mana-shu-security-key"));
                    var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var claims = new List<Claim>()
                    {
                        new Claim("PhoneNumber", loginDTO.PhoneNumber),
                        new Claim("Password",loginDTO.Password),
                        new Claim(ClaimTypes.Role, loginDTO.Role),
                    };

                    var token = new JwtSecurityToken(
                        issuer: "Issuer",
                        audience: "Audience",
                        claims: claims,
                        expires: DateTime.Now.AddMinutes(10),
                        signingCredentials: signingCredentials);

                     var s = new JwtSecurityTokenHandler().WriteToken(token).ToString();

            
                  return s;

                }
            return "User topilmadi";
            
            
           



        }
    }
}
