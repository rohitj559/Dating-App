using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User User, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}