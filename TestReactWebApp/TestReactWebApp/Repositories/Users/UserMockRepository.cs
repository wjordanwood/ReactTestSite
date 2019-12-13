using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestReactWebApp.Models;

namespace TestReactWebApp.Repositories
{
    public class UserMockRepository : IUserRepository
    {
        public User AuthenticateUser(string username, string password)
        {
            var matchingUser = Users.Where(u => u.Username == username).FirstOrDefault();

            if (matchingUser != null)
            {
                if (matchingUser.Password == password)
                {
                    return matchingUser;
                }
            }

            return null;
        }

        public List<User> Users
        {
            get
            {
                return new List<User>()
                {
                    new User
                    {
                        UserID = 1,
                        Username = "test",
                        Password = "password",
                        FirstName = "Jordan",
                        LastName = "Wood"
                    },
                    new User
                    {
                        UserID = 2,
                        Username = "mike",
                        Password = "miketest",
                        FirstName = "Mike",
                        LastName = "McBride"
                    }
                };
            }
        }
    }
}
