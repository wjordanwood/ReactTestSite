using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestReactWebApp.Models;

namespace TestReactWebApp.Repositories
{
    public interface IUserRepository
    {
        User AuthenticateUser(string username, string password);
        List<User> GetUsers();
    }
}
