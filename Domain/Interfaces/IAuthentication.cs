using Domain.DTO;

namespace Domain.Interfaces;

public interface IAuthentication
{
    public Task<GeneralResponseDTO> Register(RegisterDTO registerDTO);
    public Task<GeneralResponseDTO> Login(string username, string password);
    public Task<GeneralResponseDTO> ForgotPassword(string email);
    public Task<GeneralResponseDTO> ResetPassword(string email, string password);
}