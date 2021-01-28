
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
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<UsuarioController> _logger;
        private readonly IUsuarioService _usuarioService;
        private readonly IClienteService _clienteService;
        public UsuarioController(ILogger<UsuarioController> logger, IUsuarioService usuarioService, IClienteService clienteService)
        {
            _logger = logger;
            _usuarioService = usuarioService;
            _clienteService = clienteService;
        }

        [HttpGet("/api/cliente")]
        public ActionResult GetUsuarios()
        {
           var clientes = _clienteService.obterTodos();
            return Ok(clientes);
        }

        [HttpGet("/api/autenticacao")]
        public ActionResult autenticacao([FromBody] NewUsuarioRequest usuarioRequest)
        {
            var usuario = new Usuario();
            usuario.Nome = usuarioRequest.Nome;
            usuario.Senha = usuarioRequest.Senha;

            Boolean resposta = _usuarioService.usuarioExiste(usuario);
            return Ok(resposta);
        }

        [HttpPost("/api/cliente")]
        public ActionResult criarCliente([FromBody] NewClienteRequest clienteReq)
        {
            var cliente = new Cliente();
            cliente.Nome = clienteReq.Nome;
            cliente.dataNascimento = clienteReq.dataNascimento;
            cliente.CPF = clienteReq.CPF;
            cliente.telefones = clienteReq.telefones;


            _clienteService.adicionarCliente(cliente);

            return Ok("Cliente Criado");

        }

        [HttpPost("/api/editarcliente")]
        public ActionResult editarCliente([FromBody] NewClienteRequest clienteReq)
        {
            var cliente = new Cliente();
            cliente.Id = clienteReq.Id;
            cliente.Nome = clienteReq.Nome;
            cliente.dataNascimento = clienteReq.dataNascimento;
            cliente.CPF = clienteReq.CPF;
            cliente.telefones = clienteReq.telefones;


            _clienteService.editarCliente(cliente);

            return Ok("Cliente Editado");

        }
    }
}
