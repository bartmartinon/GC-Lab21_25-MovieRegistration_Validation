using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistrationValidation.Models
{
    public class Movie
    {
        // Fields/Properties
        public string ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; } = 1900;
        public List<string> Actors { get; set; } = new List<string>();
        public List<string> Directors { get; set; } = new List<string>();
}
}
