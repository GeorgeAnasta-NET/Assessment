using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Dtos
{
    public class MatchOddUpdateDto
    {
        [Required]
        public long MatchId { get; set; }
        [Required]
        public decimal Odd { get; set; }
        [Required]
        public int Specifier { get; set; }

    }
}
