using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask3
{
    abstract class AuthenticationService : IAuthenticationService
    {
        public AuthToken Authenticate(string username, string password)
        {
            return new AuthToken
            {
                ExpiresAt = new DateTime(year: 2021, month: 12, day: 31),
                Token = "test123"
            };
        }
    }
}
