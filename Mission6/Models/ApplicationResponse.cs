using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required]
        public string MovieTitle { get; set; }

      
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        [Range(1850, 2023)]
        public int Year { get; set; }

        [Required]
        public string DirectorFirstName { get; set; }

        [Required]
        public string DirectorLastName { get; set; }

        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }

    }
}
