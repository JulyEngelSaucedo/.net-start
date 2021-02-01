using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro.Services;
using Cadastro.Data.Models;
using Cadastro.Web.RequestModels;
namespace Cadastro.Web.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteService _clienteService;

        public ClienteController(  IClienteService clienteService)
        {
          _clienteService = clienteService;
        }


        [HttpPost]
        public ActionResult criarCliente([FromBody] NewClienteRequest clienteReq)
        {

            var cliente = new Cliente();
            cliente.Nome = clienteReq.Nome;
            cliente.dataNascimento = clienteReq.dataNascimento;
            cliente.CPF = clienteReq.CPF;
            cliente.telefones = clienteReq.telefones;

            try
            {
                _clienteService.adicionarCliente(cliente);
                return Ok(cliente);
            }
            catch (Exception e)
            {
                return StatusCode(500, new
                {
                    Message = e.Message
                });
            }




        }

        [HttpGet]
        public ActionResult GetUsuarios()
        {
            var clientes = _clienteService.obterTodos();
            return Ok(clientes);
        }


        [HttpPut]
        public ActionResult editarCliente([FromBody] NewClienteRequest clienteReq)
        {
            var cliente = new Cliente();
            cliente.Id = clienteReq.Id;
            cliente.Nome = clienteReq.Nome;
            cliente.dataNascimento = clienteReq.dataNascimento;
            cliente.CPF = clienteReq.CPF;
            cliente.telefones = clienteReq.telefones;


            _clienteService.editarCliente(cliente);

            return Ok(cliente);

        }
    }
}
