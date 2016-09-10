using System.Threading.Tasks;
using PriceCompare.Model;

namespace PriceCompare.DAL.RepositoriesIntefaces
{
    public interface IUserRepository
    {
        User AddUser(string name, string username, string password);
        Task<User> GetUser(string username);
        Task<bool> CheckUserPassword(string username, string password);
        Task<bool> IsUserExist(string username);
    }
}
