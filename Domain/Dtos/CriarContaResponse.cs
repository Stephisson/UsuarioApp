using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosApp.Domain.Dtos
{
    /// <summary> 
    /// DTO para a resposta de criação de conta de usuário. 
    /// </summary>
    public class CriarContaResponse(
        Guid id, //Id do usuário
        string nome, //Nome do usuário
        string email, //Email do usuário
        DateTime dataHoraCriacao //Data e hora de criação
    );
}