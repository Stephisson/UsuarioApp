using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UsuarioApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpPost("autenticar")] 
        public IActionResult Autenticar() 
        { 
            return Ok(); 
        }
        [HttpPost("criar")]
        public IActionResult Criar() 
        {
            return Ok(); 
        }
    }
}
