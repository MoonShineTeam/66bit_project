using System.Collections.Generic;

namespace Project_66bit.Models
{
    public class Type
    {
        public long Id {get; set;}
        public string Name { get; set;  } 
        public List<Category> Categories { get; set; }
    }
}