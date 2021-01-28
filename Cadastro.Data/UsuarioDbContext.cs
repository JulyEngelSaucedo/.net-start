using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Cadastro.Data
{
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext() { }
        public UsuarioDbContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<Models.Usuario> Usuarios {get; set;}
    }
}
