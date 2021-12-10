using GestaoPacientes.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPacientes.Data.EF.Context
{
    public class GestaoPacientesContext : DbContext
    {
        public GestaoPacientesContext(DbContextOptions<GestaoPacientesContext> options) : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
