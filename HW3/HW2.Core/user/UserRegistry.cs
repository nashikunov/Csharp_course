using System.Collections.Generic;
using System.Linq;
using HW2.Core.json;

namespace HW2.Core.user
{
    public class UserRegistry
    {
        public User GetUser(string username, string password)
        {
            using (var context = new Context())
            {
                return context.Users.Where(user => user.Username.Equals(username) && user.Password.Equals(password)).FirstOrDefault();
            }
        }

        public void AddUser(User user)
        {
            using (var context = new Context())
            {
                context.Users.Add(user);

                context.SaveChanges();
            }
        }

        public int GetNextId()
        {
            using (var context = new Context())
            {
                return context.Users.Count();
            }
        }

        public bool IsUsernameExists(string username)
        {
            using (var context = new Context())
            {
                return context.Users.Any(user => user.Username.Equals(username));
            }
        }

        public bool IsEmailExists(string email)
        {
            using (var context = new Context())
            {
                return context.Users.Any(user => user.Email.Equals(email));
            }
        }
    }
}