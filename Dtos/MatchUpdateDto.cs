using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Dtos
{
    public class MatchUpdateDto
    {
        [Required]
        public string MatchDate { get; set; }
        [Required]
        public string MatchTime { get; set; }
        [Required]
        public string TeamA { get; set; }
        [Required]
        public string TeamB { get; set; }

        public string Discription => TeamA + " - " + TeamB;
       
    }
}
