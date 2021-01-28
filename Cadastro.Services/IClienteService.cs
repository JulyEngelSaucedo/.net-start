using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Data.Models;

namespace Cadastro.Services
{
    public interface IClienteService
    {
        public void adicionarCliente(Cliente cliente);

        public void editarCliente(Cliente cliente);
     
        public List<Cliente> obterTodos();

    }
}
