using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaileyHullingerAssignment3.Models
{
    //model for the data that will be collected about movies
    public class MovieResponse
    {
        
        public string Category { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
    }
}
