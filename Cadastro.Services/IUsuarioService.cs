using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Data.Models;

namespace Cadastro.Services
{
    public interface IUsuarioService
    {
        public void adicionarUsuario(Usuario usuario);
        public void deletarUsuario(int usuarioId);
        public List<Usuario> obterTodos();
      
    }
}
