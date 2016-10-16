using System.Threading.Tasks;
using PriceCompare.Model;

namespace PriceCompare.DAL.RepositoriesIntefaces
{
    //Well done- encapsulating the DAO is a very good practice.
    //However- issues may arise since the returned types are annotated with EF attributes
    //Consider: http://automapper.org/ and https://github.com/AutoMapper/AutoMapper/wiki/Getting-started
    public interface IUserRepository
    {
        User AddUser(string name, string username, string password);
        Task<User> GetUser(string username);
        Task<bool> CheckUserPassword(string username, string password);
        Task<bool> IsUserExist(string username);
    }
}
