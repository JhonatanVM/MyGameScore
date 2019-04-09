using MyGameScore.Domain.Entities;
using MyGameScore.Domain.Interfaces.Domain;
using MyGameScore.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyGameScore.Domain.Services
{
    public class MatchDomainService : IMatchDomainService
    {
        private readonly IMatchRepository _matchRepository;

        public MatchDomainService(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }

        public async Task<Match> GetByIdAsync(int id)
        {
            return await _matchRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Match>> GetAsync()
        {
            return await _matchRepository.GetAsync();
        }

        public async Task<Results> GetResultsAsync()
        {
            return await _matchRepository.GetResultsAsync();
        }

        public async Task InsertAsync(Match match)
        {
            var record = await _matchRepository.VerifiyRecordAsync(match.Score);

            match.IsHighestScore = match.Score > record && record != 0;

            await _matchRepository.InsertAsync(match);
        }

        public async Task DeleteAsync(Match match)
        {
            await _matchRepository.DeleteAsync(match);
        }
    }
}
