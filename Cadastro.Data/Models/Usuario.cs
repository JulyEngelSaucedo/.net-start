using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Models
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Nome { get; set; }

        public string Senha { get; set; }

        public string CPF { get; set; }
        public DateTime dataNascimento { get; set; }
        public List<string> telefones { get; set; }
    }
}
