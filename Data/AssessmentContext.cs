using Assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment.Data {
    public class AssessmentContext :DbContext{

        public AssessmentContext(DbContextOptions<AssessmentContext> opt): base(opt) 
        {

        }

        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchOdd> MatchOdds { get; set; }
    }
}
