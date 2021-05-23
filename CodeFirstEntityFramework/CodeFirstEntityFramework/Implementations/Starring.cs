using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstEntityFramework
{
    public class Starring : IStarring
    {
        public int ActorId { get; set; }
        public int MovieId { get; set; }
    }
}
