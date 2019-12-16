using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestReactWebApp.Models;
using TestReactWebApp.Repositories;

namespace TestReactWebApp.Services
{
    public class UserService
    {
        public IUserRepository UserRepository = new UserTextRepository();

        public User AuthenticateCustomer(string username, string password)
        {
            return UserRepository.AuthenticateUser(username, password);
        }

        public List<User> GetUsers()
        {
            return UserRepository.GetUsers();
        }
    }
}
