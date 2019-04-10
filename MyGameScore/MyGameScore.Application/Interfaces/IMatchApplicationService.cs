using MyGameScore.Application.Services.AppMatch.Input;
using MyGameScore.Application.Services.AppMatch.ViewModel;
using MyGameScore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyGameScore.Application.Interfaces
{
    public interface IMatchApplicationService
    {
        Task<IEnumerable<Match>> GetAsync();
        Task<Results> GetResultsAsync();
        Task<Match> GetByIdAsync(int id);
        Task<MatchViewModel> InsertAsync(MatchInput match);
        Task<bool> DeleteAsync(int id);
    }
}
