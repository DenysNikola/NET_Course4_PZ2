using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class UserRepository
    {
        private readonly MyDbContext _dbContext;

        public UserRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Create
        public void AddUser(User user)
        {
            _dbContext.User.Add(user);
            _dbContext.SaveChanges();
        }

        // Read
        public List<User> GetAllUsers()
        {
            return _dbContext.User.ToList();
        }

        // Update
        public void UpdateUser(User updatedUser)
        {
            var existingUser = _dbContext.User.Find(updatedUser.UserID);

            if (existingUser != null)
            {
                // Update properties as needed
                existingUser.Username = updatedUser.Username;
                existingUser.Email = updatedUser.Email;
                existingUser.Password = updatedUser.Password;

                _dbContext.SaveChanges();
            }
        }

        // Delete
        public void DeleteUser(int userId)
        {
            var userToDelete = _dbContext.User.Find(userId);

            if (userToDelete != null)
            {
                _dbContext.User.Remove(userToDelete);
                _dbContext.SaveChanges();
            }
        }
    }
}