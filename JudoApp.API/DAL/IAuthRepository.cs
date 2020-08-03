using System.Threading.Tasks;
using JudoApp.API.Models;

namespace JudoApp.API.DAL
{
    public interface IAuthRepository
    {
         Task<User>Register(User user,string password);
         Task<User>Login(string username,string password);
         Task<bool>UserExists(string username);
    }
}