using System; 
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEntityFramework
{ 
    public class Starring : IStarring
    {
        public int ActorId { get; set; } 
        public int MovieId { get; set; } 
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
    }
}
