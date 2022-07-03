using Microsoft.AspNetCore.Mvc;
using mystore.Server.Models;
using mystore.User;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace mystore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public dbContext.ContextModel Context { get; set; }
        public AuthController(dbContext.ContextModel context)
        {
            Context = context;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Athenticate([FromBody] RegesterModel model)
        {
            if (model.Username != string.Empty)
            {
                if (model.Password != string.Empty)
                {

                    if (Context.Users.FirstOrDefault(x => x.Username == model.Username) == null)
                    {


                        CreatePasswordHash(model.Password, out byte[] hassh, out byte[] salt);
                        var Nuser = new UserModel()
                        {
                            Username = model.Username,
                            Age = model.Age,
                            PhoneNummber = model.PhoneNummber,
                            Email = model.Email,

                        };
                        Nuser.Password = hassh;
                        Nuser.KeyPassword = salt;

                        await Context.Users.AddAsync(Nuser);
                        await Context.SaveChangesAsync();
                        return Ok(new ResponseModel() { status = "Sucssesfuly", message = "Adding done " });

                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else
            {

            }





            return Ok();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> Login([FromBody] LoginModle modle)
        {





            return Ok();
        }
        private void CreatePasswordHash(string password, out byte[] PasswordHash, out byte[] PasswordSalt)
        {
            using (var hasher = new HMACSHA256())
            {

                PasswordHash = hasher.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                PasswordSalt = hasher.Key;

            }
        }
        private bool VerifyPasswordHash(string password, byte[] PasswordHash, byte[] PasswordSalt)
        {
            using (var hasher = new HMACSHA256(PasswordSalt))
            {

                var computedHash = hasher.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(PasswordHash);

            }
        }
    }
}
