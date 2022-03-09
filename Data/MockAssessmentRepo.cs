using Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Data
{
    public class MockAssessmentRepo : IMatchRepo
    {
        public void CreateMatch(Match mtc)
        {
            throw new NotImplementedException();
        }

        public void DeleteMatch(Match mtc)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Match> GetAllMatches()
        {
            //var matches = new List<Match>() {
            //    new Match { Id = 0, TeamA = "AEK", TeamB = "OSFP", Sport = Match.Sports.Basketball, MatchDate = DateTime.Now.ToShortDateString(), MatchTime = DateTime.Now.ToShortTimeString() },
            //    new Match { Id = 0, TeamA = "AEK", TeamB = "PAOK", Sport = Match.Sports.Football, MatchDate = DateTime.Now.ToShortDateString(), MatchTime = DateTime.Now.ToShortTimeString() },
            //    new Match { Id = 0, TeamA = "AEK", TeamB = "PAO", Sport = Match.Sports.Basketball, MatchDate = DateTime.Now.ToShortDateString(), MatchTime = DateTime.Now.ToShortTimeString() }
            //};

            // return matches;
            throw new NotImplementedException();
        }

        public Match GetMatchById(long Id)
        {
            //return new Match { Id = 0, TeamA = "AEK", TeamB = "OSFP", Sport = Match.Sports.Football, MatchDate = DateTime.Now.ToShortDateString(), MatchTime = DateTime.Now.ToShortTimeString() };
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateMatch(Match mtc)
        {
            throw new NotImplementedException();
        }
    }
}
