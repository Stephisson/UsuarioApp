namespace UsuariosApp.Domain.Dtos;

/// <summary>
/// DTO para a requisição de autenticação de usuário.
/// </summary>
public record AutenticarRequest(
    string email, //email do usuário
    string senha  //senha do usuário
);