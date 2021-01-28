using Cadastro.Data.Models;
using Cadastro.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.Services
{
    public class ClienteService : IClienteService
    {

        private readonly UsuarioDbContext _db;

        public ClienteService(UsuarioDbContext db)
        {
            _db = db;
        }

        void IClienteService.adicionarCliente(Cliente cliente)
        {
            _db.Add(cliente);
            _db.SaveChanges();
        }

     



        void IClienteService.editarCliente(Cliente cliente)
        {
            _db.Update(cliente);
            _db.SaveChanges();
        }

        List<Cliente> IClienteService.obterTodos()
        {
            return _db.Cliente.ToList();
        }


   
    }
}