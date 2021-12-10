using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPacientes.Business.Models
{
    public class Endereco : EntidadeBase
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
