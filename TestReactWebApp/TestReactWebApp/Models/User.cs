using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestReactWebApp.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
