using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission5_ear69.Models
{ /*post stuff so that the inofrmation shows*/
    public class MovieResponse
    {   
        [Key]
        [Required]
        public int MovieId { get; set; }
        
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edit { get; set; }
        public string Lent { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }
     
        //setting up the table
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }   
}
