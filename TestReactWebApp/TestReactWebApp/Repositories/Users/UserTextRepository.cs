using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TestReactWebApp.Extenstions;
using TestReactWebApp.Models;

namespace TestReactWebApp.Repositories
{
    public class UserTextRepository : IUserRepository
    {
        public User AuthenticateUser(string username, string password)
        {
            var jsontext = File.ReadAllText(@"C:\Users\User\Desktop\users.txt");
            var users = JsonConvert.DeserializeObject<IList<User>>(jsontext, new JsonSerializerSettings() { ContractResolver = new JsonIgnoreAttributeIgnorerContractResolver() });
            var matchingUser = users.Where(u => u.Username == username).FirstOrDefault();

            if (matchingUser != null)
            {
                if (matchingUser.Password == password)
                {
                    return matchingUser;
                }
            }

            return null;
        }

        public List<User> GetUsers()
        {
            var jsontext = File.ReadAllText(@"C:\Users\User\Desktop\users.txt");
            var users = JsonConvert.DeserializeObject<IList<User>>(jsontext, new JsonSerializerSettings() { ContractResolver = new JsonIgnoreAttributeIgnorerContractResolver() });
            return users.ToList();
        }
    }
}
