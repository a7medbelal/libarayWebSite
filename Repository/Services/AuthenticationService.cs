using Domain.Models;
using Domain.DTO;
using Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace Services.Services;

public class AuthenticationService : IAuthentication
{
    private readonly UserManager<User> _userManager;
    private readonly IConfiguration _configuration;

    public AuthenticationService(UserManager<User> userManager, IConfiguration configuration)
    {
        _userManager = userManager;
        _configuration = configuration;
    }
    
    public async Task<GeneralResponseDTO> Register(RegisterDTO registerDTO)
    {
        if (await _userManager.FindByEmailAsync(registerDTO.Email) != null)
        {
            return new GeneralResponseDTO
            {
                Success = false,
            };
        }

        if (await _userManager.FindByNameAsync(registerDTO.Username) != null)
        {
            return new GeneralResponseDTO
            {
                Success = false
            };
        }

        var User = new User
        {
            Email = registerDTO.Email,
            UserName = registerDTO.Username
        };
        IdentityResult result = await _userManager.CreateAsync(User, registerDTO.Password);
        if (result.Succeeded)
        {
            return new GeneralResponseDTO
            {
                Success = true,
                Data = User
            };
        }

        return new GeneralResponseDTO
        {
            Success = false
        };
    }

    public Task<GeneralResponseDTO> Login(string username, string password)
    {
        throw new NotImplementedException();
    }

    public Task<GeneralResponseDTO> ForgotPassword(string email)
    {
        throw new NotImplementedException();
    }

    public Task<GeneralResponseDTO> ResetPassword(string email, string password)
    {
        throw new NotImplementedException();
    }
}