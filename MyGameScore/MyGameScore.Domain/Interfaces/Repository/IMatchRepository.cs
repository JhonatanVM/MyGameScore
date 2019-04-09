using MyGameScore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyGameScore.Domain.Interfaces.Repository
{
    public interface IMatchRepository
    {
        Task<Match> GetByIdAsync(int id);
        Task<Results> GetResultsAsync();
        Task<IEnumerable<Match>> GetAsync();
        Task<int> VerifiyRecordAsync(int score);
        Task InsertAsync(Match match);
        Task DeleteAsync(Match match);
    }
}
