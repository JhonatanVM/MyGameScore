using MyGameScore.Application.Interfaces;
using MyGameScore.Application.Services.AppMatch.Input;
using MyGameScore.Application.Services.AppMatch.ViewModel;
using MyGameScore.Domain.Entities;
using MyGameScore.Domain.Interfaces.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyGameScore.Application.Services.AppMatch
{
    public class MatchApplicationService : IMatchApplicationService
    {
        private readonly IMatchDomainService _matchDomainService;

        public MatchApplicationService(IMatchDomainService matchDomainService)
        {
            _matchDomainService = matchDomainService;
        }

        public async Task<Match> GetByIdAsync(int id)
        {
            return await _matchDomainService.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Match>> GetAsync()
        {
            return await _matchDomainService.GetAsync();
        }

        public async Task<Results> GetResultsAsync()
        {
            return await _matchDomainService.GetResultsAsync();
        }

        public async Task<MatchViewModel> InsertAsync(MatchInput match)
        {
            var entity = new Match(match.Date, match.Score);

            if (!entity.IsValid())
                return default(MatchViewModel);

            await _matchDomainService.InsertAsync(entity);

            if (entity.Id > 0)
                return new MatchViewModel(entity.Date, entity.Score);

            return default(MatchViewModel);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var match = await GetByIdAsync(id);

            if (match == null)
                return false;

            await _matchDomainService.DeleteAsync(match);
            return true;
        }
    }
}
