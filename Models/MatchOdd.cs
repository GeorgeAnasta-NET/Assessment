using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Models
{
    public class MatchOdd
    {
        public long Id { get; set; }
        public long MatchId { get; set; }
        public Match Match { get; set; }
        public decimal Odd { get; set; }

        public Specifiers Specifier
        {
            get { return _specifier; }
            set { _specifier = value; }
        }

        private Specifiers _specifier;
        public enum Specifiers
        {
            homeWin = 1,
            visitorWin = 2,
            tie = 3
        }
    }
}
