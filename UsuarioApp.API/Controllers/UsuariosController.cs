using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsuariosApp.Domain.Interfaces.Services;

namespace UsuarioApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController(IUsuarioService usuarioService) : ControllerBase
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
