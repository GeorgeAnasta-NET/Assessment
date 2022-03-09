using Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Dtos
{
    public class MatchOddReadDto
    {
        public long Id { get; set; }
        public long MatchId { get; set; }
        public decimal Odd { get; set; }
        public int Specifier { get; set; }
    }
}
