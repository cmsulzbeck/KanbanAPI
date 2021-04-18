using BACK.Models;
using Microsoft.AspNetCore.Mvc;

namespace BACK.Controllers
{
    [ApiController]
    [Route("/login")]
    public class LoginController : ControllerBase
    {
        public LoginController() {}

        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            // TODO: Implementar cadastro

            return Ok("Teste de cadastro.");
        }
    }
}