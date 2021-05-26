using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstEntityFramework
{
    public class Actor : IActor
    {
        public int ActorId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public Actor()
        {
        }

        public Actor(int actorId, string firstname, string lastname, DateTime birthday)
        {
            ActorId = actorId;
            Firstname = firstname;
            Lastname = lastname;
            Birthday = birthday;
        }

        public ICollection<Starring> Starring { get; set; }
    }
}
