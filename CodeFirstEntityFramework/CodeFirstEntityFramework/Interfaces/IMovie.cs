using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstEntityFramework
{
    public interface IMovie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int AgeRestriction{ get; set; }
        public float Price { get; set; }
        public ICollection<Copy> Copies { get; set; }
        public ICollection<Starring> Starring { get; set; } 

    }
}
