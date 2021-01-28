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
    }
}
