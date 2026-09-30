using System;
using System.Collections.Generic;
using System.Text;
using UsuariosApp.Domain.Entities;

namespace UsuariosApp.Domain.Interfaces
{
    /// <summary> 
    /// Interface para definir os métodos do repositório de perfil. 
    /// </summary>
    public interface IPerfilRepository : IBaseRepository<Perfil>
    {
        Perfil? Get(string nome);
    }
}