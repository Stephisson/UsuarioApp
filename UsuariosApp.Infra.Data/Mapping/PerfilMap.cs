using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UsuariosApp.Domain.Entities;

namespace UsuariosApp.Infra.Data.Mapping
{
    /// <summary> 
    /// Mapeamento da entidade Perfil 
    /// </summary> public class PerfilMap
    public class PerfilMap : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.ToTable("PERFIS"); //nome da tabela
            builder.HasKey(p => p.Id); //chave primária
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.Nome).HasColumnName("NOME").HasMaxLength(25).IsRequired();
            builder.HasIndex(p => p.Nome).IsUnique(); //definindo o campo como unico

        }
    }
}