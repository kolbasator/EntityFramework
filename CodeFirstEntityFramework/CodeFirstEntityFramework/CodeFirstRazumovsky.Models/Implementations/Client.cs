using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstEntityFramework
{
    public class Client : IClient
    {
        public int ClientId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Birthday { get; set; }
        public Client()
        {
        }

        public Client(int clientId, string firstname, string lastname, DateTime? birthday)
        {
            ClientId = clientId;
            Firstname = firstname;
            Lastname = lastname;
            Birthday = birthday;
        }
        public ICollection<Rental> Rentals { get; set; }
        public override string ToString()
        {
            return $"{ClientId},{Firstname},{Lastname},{Birthday}";
        }
    }
}
