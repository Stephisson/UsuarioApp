using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosApp.Domain.Dtos
{
    /// <summary> 
    /// DTO para a requisição de criação de conta de usuário. 
    /// </summary>
    public class CriarContaRequest(
        string nome, //Nome do usuário
        string email, //Email do usuário
        string senha //Senha do usuário
    );
}