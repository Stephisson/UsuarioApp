using System;
using System.Collections.Generic;
using System.Text;
using UsuariosApp.Domain.Dtos;

namespace UsuariosApp.Domain.Interfaces.Services
{
    /// <summary> 
    /// Interface para abstração dos métodos da camada de serviço de usuários 
    /// </summary>
    public interface IUsuarioService
    {
        /// <summary> 
        /// Método para criação de conta de usuário 
        /// </summary>

        CriarContaResponse CriarConta(CriarContaRequest request);
    }
}