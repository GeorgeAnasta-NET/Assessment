using Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Data
{
    public interface IMatchRepo
    {
        bool SaveChanges();
        IEnumerable<Match> GetAllMatches();
        Match GetMatchById(long Id);
        void CreateMatch(Match mtc);
        void UpdateMatch(Match mtc);
        void DeleteMatch(Match mtc);

    }
}
