using Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Data
{
    public class SqlAssessmentRepo : IMatchRepo, IMatchOddRepo
    {
        private readonly AssessmentContext _context;

        public SqlAssessmentRepo(AssessmentContext context)
        {
            _context = context;
        }

        public void CreateMatch(Match mtc)
        {
            if(mtc is null)
            {
                throw new ArgumentNullException(nameof(mtc));
            }

            _context.Matches.Add(mtc);
        }

        public void CreateMatchOdd(MatchOdd mtc)
        {
            if (mtc is null)
            {
                throw new ArgumentNullException(nameof(mtc));
            }

            _context.MatchOdds.Add(mtc);
        }

        public void DeleteMatch(Match mtc)
        {
            if (mtc is null)
            {
                throw new ArgumentNullException(nameof(mtc));
            }
            _context.Matches.Remove(mtc);
        }

        public void DeleteMatchOdd(MatchOdd mtc)
        {
            if (mtc is null)
            {
                throw new ArgumentNullException(nameof(mtc));
            }
            _context.MatchOdds.Remove(mtc);
        }

        public IEnumerable<Match> GetAllMatches()
        {
            return _context.Matches.ToList();
        }

        public IEnumerable<MatchOdd> GetAllOdds()
        {
            return _context.MatchOdds.ToList();
        }

        public Match GetMatchById(long Id)
        {
            return _context.Matches.FirstOrDefault(m => m.Id == Id);
        }

        public MatchOdd GetOddById(long Id)
        {
            return _context.MatchOdds.FirstOrDefault(m => m.Id == Id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateMatch(Match mtc)
        {
            //Nothing
        }

        public void UpdateMatchOdd(MatchOdd mtc)
        {
           //nothing
        }
    }
}
