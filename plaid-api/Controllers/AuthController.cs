using Microsoft.AspNetCore.Mvc;

namespace plaid_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IConfiguration configuration;

        public AuthController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        //[HttpGet("authorized"), Authorize]
        //public ActionResult authorized()
        //{
        //    var jwt = Request.Headers[HeaderNames.Authorization].ToString();
        //    var jot = jwt.Remove(0, 6);
        //    var handler = new JwtSecurityTokenHandler();
        //    var token = handler.ReadJwtToken(jot);

        //    return Ok(token);
        //}

        //[HttpPost("login")]
        //public ActionResult<string> Login(UserDTO userDTO)
        //{
        //    if (userDTO.username.Equals("jonah") && userDTO.password.Equals("murrey"))
        //    {
        //        var token = createToken();
        //        return Ok(token);
        //    }
        //    return Unauthorized("you are not authorized");
        //}
        //private string createToken()
        //{

        //    List<Claim> claims = new List<Claim>()
        //    {
        //        new Claim(ClaimTypes.Name,"jonah"),
        //        new Claim("client_id","gfsdgfsd"),
        //        new Claim("secret","sdfasdfasd")
        //    };
        //    var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(configuration.GetSection("AppSettings:Token").Value));
        //    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
        //    var token = new JwtSecurityToken(
        //        claims: claims,
        //        expires: DateTime.Now.AddDays(1),
        //        signingCredentials: creds
        //        );
        //    var jwt = new JwtSecurityTokenHandler().WriteToken(token);
        //    return jwt;
        //}
    }
}
