using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkLearning
{
    public class NetworkUser : INetworkUser
    {
        public int Age { get; set; }
        public int NetworkUserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } 
    }
}
