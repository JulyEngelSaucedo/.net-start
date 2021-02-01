
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cadastro.Services;
using Cadastro.Data.Models;
using Cadastro.Web.RequestModels;
using System;

namespace Cadastro.Web.Controllers
{
    [ApiController]

    public class UsuarioController : ControllerBase
    {

        
        private readonly IUsuarioService _usuarioService;
      
        public UsuarioController(IUsuarioService usuarioService, IClienteService clienteService)
        {
          
            _usuarioService = usuarioService;
          
        }

        

        [HttpPost("/api/autenticacao")]
        public ActionResult autenticacao([FromBody] NewUsuarioRequest usuarioRequest)
        {
            var usuario = new Usuario();
            usuario.Nome = usuarioRequest.Nome;
            usuario.Senha = usuarioRequest.Senha;

            Boolean resposta = _usuarioService.usuarioExiste(usuario);
            return Ok(resposta);
        }

        

    }
}
