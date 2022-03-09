using Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Data
{
    public interface IMatchOddRepo
    {
        bool SaveChanges();
        IEnumerable<MatchOdd> GetAllOdds();
        MatchOdd GetOddById(long Id);
        void CreateMatchOdd(MatchOdd mtc);
        void UpdateMatchOdd(MatchOdd mtc);
        void DeleteMatchOdd(MatchOdd mtc);
    }
}
