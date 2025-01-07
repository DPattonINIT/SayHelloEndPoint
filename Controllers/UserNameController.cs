using Microsoft.AspNetCore.Mvc;

namespace SayHello.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserNameController : ControllerBase
    {
        [HttpGet]
        [Route("FetchUserName/{userName}")]
        public string GetName(string userName)
        {
            return ($"Hello , {userName}!");
        }

    }
}