using MyGameScore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyGameScore.Domain.Interfaces.Domain
{
    public interface IMatchDomainService
    {
        Task<Match> GetByIdAsync(int id);
        Task<Results> GetResultsAsync();
        Task<IEnumerable<Match>> GetAsync();
        Task InsertAsync(Match match);
        Task DeleteAsync(Match match);
    }
}
