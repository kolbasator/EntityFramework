using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkLearning
{
    public interface IPost
    { 
        public int PostId { get; set; } 
        public int UserId { get; set; }  
        public string Content { get; set; }  
    }
}
