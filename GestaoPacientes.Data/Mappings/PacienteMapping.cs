using GestaoPacientes.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPacientes.Data.EF.Mappings
{
    public class PacienteMapping : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.CPF)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.RG)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.DataNascimento)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(c => c.Telefone)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(c => c.IdEndereco)
                .IsRequired();


            builder.ToTable("Paciente");
        }

    }
}
