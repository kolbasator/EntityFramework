using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstEntityFramework
{
    public interface IRental
    {
        
        public int CopyId { get; set; }
        public int ClientId { get; set; }
        public DateTime DateOfRental { get; set; }
        public DateTime DateOfReturn { get; set; }
        public Copy Copy { get; set; }
        public Client Client { get; set; }

    }
}
