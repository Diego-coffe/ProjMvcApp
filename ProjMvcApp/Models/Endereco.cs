using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjMvcApp.Models
{
    public class Endereco : Entity
    {
        public Guid FornecedorId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidadedo { get; set; }
        public string Estado { get; set; }

        /* EF Relation */
        public Fornecedor Fornecedor { get; set; }

    }
}
