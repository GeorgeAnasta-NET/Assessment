using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Models
{

    public class Match
    {

        public long Id { get; set; }
        [Required]
        public DateTime MatchDate { get; set; }
        [Required]
        public string MatchTime { get { return _dateTime.ToShortTimeString(); } set { _dateTime = MatchDate; } }
        [Required]
        public string TeamA { get; set; }
        [Required]
        public string TeamB { get; set; }

        public string Discription => TeamA + " - " + TeamB;
        [Required]
        public Sports Sport {
            get { return _sport; }
            set { _sport = value; }
        }

        private Sports _sport;
        private DateTime _dateTime;

        public enum Sports
        {
            Football = 1,
            Basketball = 2
        }
    }
}
