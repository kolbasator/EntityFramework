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
        public Starring()
        {
        }

        public Starring(int actorId, int movieId)
        {
            ActorId = actorId;
            MovieId = movieId;
        }
    }
}
