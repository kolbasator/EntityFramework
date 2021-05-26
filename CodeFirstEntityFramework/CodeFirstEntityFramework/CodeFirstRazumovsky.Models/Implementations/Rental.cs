using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEntityFramework
{
   [Keyless]
    public class Rental : IRental
    {
        public int CopyId { get; set; } 
        public int ClientId { get; set; } 
        public Client Client { get; set; }
        public Copy Copy { get; set; }
        public DateTime? DateOfRental { get; set; }
        public DateTime? DateOfReturn { get; set; }
        public Rental(int clientId, int copyId, DateTime? dateOfRental, DateTime? dateOfReturn)
        {
            CopyId = copyId;
            ClientId = clientId;
            DateOfRental = dateOfRental;
            DateOfReturn = dateOfReturn;
        }
    }
}
