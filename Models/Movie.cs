using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieCollection.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Category { get; set; }
        
        [Required(ErrorMessage = "This field cannot be empty")]
        [Range(1888, 2021, ErrorMessage = "Must be a year between 1888 and 2021")]
        public int Year { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public string Director { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public string Rating { get; set; }

        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        public string? Notes { get; set; }
    }
}
