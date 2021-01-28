
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cadastro.Services;
using Cadastro.Data.Models;
using Cadastro.Web.RequestModels;
namespace Cadastro.Web.Controllers
{
    [ApiController]

    public class UsuarioController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<UsuarioController> _logger;
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(ILogger<UsuarioController> logger, IUsuarioService usuarioService)
        {
            _logger = logger;
            _usuarioService = usuarioService;
        }

        [HttpGet("/api/usuario")]
        public ActionResult GetUsuarios()
        {
           var usuarios = _usuarioService.obterTodos();
            return Ok(usuarios);
        }

        [HttpPost("/api/usuario")]
        public ActionResult criarUSuario([FromBody] NewUsuarioRequest bookRequest)
        {
            var usuario = new Usuario();
            usuario.CPF = bookRequest.CPF;
            usuario.Nome = bookRequest.Nome;


            _usuarioService.adicionarUsuario(usuario);

            return Ok("Livro Criado");

        }
    }
}
