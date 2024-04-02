using MarketJunctionAPI.Data;
using MarketJunctionAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MarketJunctionAPI.Services
{
    public class AuthenticationService
    {
        private readonly ApplicationDbContext _dbContext;

        public AuthenticationService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User?> AuthenticateUser(string username, string password)
        {
            // Query the Users table or collection to find a user with the provided username and password
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            // If a matching user is found, return the user object
            if (user != null)
            {
                return user;
            }

            // If no matching user is found, return null
            return null;
        }
    }
}
