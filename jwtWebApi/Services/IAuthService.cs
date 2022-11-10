using jwtWebApi.Models;

namespace jwtWebApi.Services
{
    public interface IAuthService
    {

        Task<AuthModel> GetUserProfileAsync(string id);
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> LoginAsync(LoginModel model);
    }
}
