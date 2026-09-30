using System;
using System.Collections.Generic;
using System.Text;
using UsuariosApp.Domain.Entities;

namespace UsuariosApp.Domain.Interfaces
{
    /// <summary> 
    /// Interface para definir os métodos do repositório de usuário. 
    /// </summary>
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Usuario? Get(string email);
        Usuario? Get(string email, string senha);
    }
}
