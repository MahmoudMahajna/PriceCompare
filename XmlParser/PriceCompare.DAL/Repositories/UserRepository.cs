using System;
using System.Data.Entity;
using System.Threading.Tasks;
using PriceCompare.DAL.Data;
using PriceCompare.Model;

namespace PriceCompare.DAL.Repositories
{
    public class UserRepository
    {
        private readonly PriceCompareDbContext _context;

        public UserRepository(PriceCompareDbContext context)
        {
            _context = context;
        }

        public User AddUser(string name, string username, string password)
        {
            if (name == null || username == null || password == null)
            {
                throw new ArgumentNullException();
            }
            var user= _context.Users.Add(new User()
            {
                Name = name,
                Username = username,
                Password = password,
                Cart = new Cart()
            });
            _context.SaveChanges();
            return user;
        }

        public async Task<User> GetUser(string username)
        {
            if (username==null)
            {
                throw new ArgumentNullException(nameof(username));
            }
            return await _context.Users.FirstOrDefaultAsync(user => user.Username.Equals(username));
        }

        public async Task<bool> CheckUserPassword(string username, string password)
        {
            if ( username == null || password == null)
            {
                throw new ArgumentNullException(username==null?nameof(username):nameof(password));
            }
            var result = await _context.Users.FirstOrDefaultAsync(user => user.Username.Equals(username));
            return result != null && result.Password.Equals(password);
        }

        public async Task<bool> IsUserExist(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username));
            }
            var result = await _context.Users.FirstOrDefaultAsync(user => user.Username.Equals(username));
            return result != null;
        }
    }
}
