using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstEntityFramework
{
    public interface IActor
    {
        public int ActorId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public ICollection<Starring> Starring { get; set; }

    }
}
