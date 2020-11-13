using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistrationValidation.Models
{
    public class Movie
    {
        // Fields/Properties
        [Required(ErrorMessage = " Please enter an ID.")]
        [StringLength(10, ErrorMessage = "ID is too long.")]
        [RegularExpression(@"[0-9A-F]+", ErrorMessage = "Invalid ID format.")]
        public string ID { get; set; }
        [Required(ErrorMessage = "Please enter a Title.")]
        [StringLength(50, ErrorMessage = "Title is too long, please keep below 50 characters.")]
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; } = 1900;
        public List<string> Actors { get; set; } = new List<string>();
        public List<string> Directors { get; set; } = new List<string>();
    }
}
