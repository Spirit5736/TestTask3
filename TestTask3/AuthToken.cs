using System;

namespace TestTask3
{
    class AuthToken
    {
        
        /// <summary>
        /// Authentication token string.
        /// </summary>
        public String Token { get; set; }
        /// <summary>
        /// Date and time the token expires at (UTC).
        /// </summary>
        public DateTime ExpiresAt { get; set; }
    }
}

