using udemy1.Services.CharacterService;

namespace udemy1.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user,String password);
        Task<ServiceResponse<string>> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
