using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPacientes.Business.Models
{
    public class Paciente : EntidadeBase
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        [ForeignKey("Endereco")]
        public Guid IdEndereco { get; set; }
        public virtual Endereco Endereco { get; set; }
        public Guid IdUsuario { get; set; }
    }
}
