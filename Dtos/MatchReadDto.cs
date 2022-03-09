using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Dtos
{
    public class MatchReadDto
    {

        public long Id { get; set; }
        public DateTime MatchDate { get; set; }
        public string MatchTime { get; set; }
        public string Discription { get; set; }
        
        
    }
}
