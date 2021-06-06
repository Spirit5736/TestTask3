using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask3
{
   class User : IUser
    {
        private readonly IAuthenticationService _authservice;
        public string AuthToken { get; private set; }

        public User(IAuthenticationService authservice)
        {
            _authservice = authservice;
        }

        public void Auth(string username, string password)
        {
            var authToken = _authservice.Authenticate(username, password);
            AuthToken = authToken.Token;
        }
    }
}
