using HR.ERP.API.Dtos;

namespace HR.ERP.API.Service.Auth
{
    public interface IAuthService
    {
        Task<AuthResponseDto> Login(LoginDto loginDto);
    }
}
