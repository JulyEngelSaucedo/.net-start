using Cadastro.Data.Models;
using Cadastro.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.Services
{
    public class UsuarioService : IUsuarioService
    {

        private readonly UsuarioDbContext _db;

        public  UsuarioService(UsuarioDbContext db){
            _db = db;
        }

        void IUsuarioService.adicionarUsuario(Usuario usuario)
        {
            _db.Add(usuario);
            _db.SaveChanges();
        }

        void IUsuarioService.deletarUsuario(int usuarioId)
        {
            throw new NotImplementedException();
        }

        List<Usuario> IUsuarioService.obterTodos()
        {
            return _db.Usuarios.ToList();
        }

       
        bool IUsuarioService.usuarioExiste(Usuario usuario)
        {
            List<Usuario> listaDeUsuarios = _db.Usuarios.ToList();
            foreach (Usuario elemento in listaDeUsuarios)

            {
             
                if (elemento.Nome.Equals(usuario.Nome) && elemento.Senha.Equals(usuario.Senha))
                {
                   
                    return true;
                }

            }
            return false;
        }
    }
}
