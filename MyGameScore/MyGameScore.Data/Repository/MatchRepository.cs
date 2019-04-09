using Microsoft.EntityFrameworkCore;
using MyGameScore.Data.Context;
using MyGameScore.Domain.Entities;
using MyGameScore.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameScore.Data.Repository
{
    public class MatchRepository : IMatchRepository
    {
        private readonly MyGameScoreContext _context;

        public MatchRepository(MyGameScoreContext context)
        {
            _context = context;
        }

        public async Task<Match> GetByIdAsync(int id)
        {
            return await _context.Matches.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<Match>> GetAsync()
        {
            return await _context.Matches.ToListAsync();;
        }

        public async Task<Results> GetResultsAsync()
        {
            var allEntities = await _context.Matches.ToListAsync();

            if (allEntities.Any())
            {
                var results = new Results()
                {
                    StartDate = allEntities.Min(e => e.Date),
                    EndDate = allEntities.Max(e => e.Date),
                    QuantityOfGames = allEntities.Count,
                    TotalScore = allEntities.Sum(e => e.Score),
                    AverageScore = allEntities.Average(e => e.Score),
                    HighestScore = allEntities.Max(e => e.Score),
                    LowestScore = allEntities.Min(e => e.Score),
                    TimesRecordBeated = allEntities.Count(e => e.IsHighestScore == true)
                };
                return results;
            }

            return default(Results);
        }

        public async Task InsertAsync(Match match)
        {
            await _context.AddAsync(match);
            await _context.SaveChangesAsync();
        }

        public async Task<int> VerifiyRecordAsync(int score)
        {
            var matches = await GetAsync();

            int record = 0;

            if (matches.Any())
                record = matches.Max(e => e.Score);

            return record;
        }

        public async Task DeleteAsync(Match match)
        {
            await Task.FromResult(_context.Matches.Remove(match));
            await _context.SaveChangesAsync();
        }
    }
}
