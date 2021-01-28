using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Web.RequestModels
{
    public class NewClienteRequest
    {
        public long Id { get; set; }
        public string Nome { get; set; }

        public string CPF { get; set; }
        public DateTime dataNascimento { get; set; }
        public List<string> telefones { get; set; }
    }
}
