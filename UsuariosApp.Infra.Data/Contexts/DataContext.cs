using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UsuariosApp.Infra.Data.Mapping;
using UsuariosApp.Domain.Entities;

namespace UsuariosApp.Infra.Data.Contexts
{
    /// <summary> 
    /// Classe de contexto para conexão com o banco de dados. 
    /// </summary>
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Configura a string de conexão com o banco de dados SQL Server.
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UsuariosApp;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30"); 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Adicionar as classes de mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new PerfilMap());
        }
    }
}