using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class HistoryService : IHistoryService
    {
        private readonly IHistoryRepository historyRepository;
        public HistoryService(IHistoryRepository historyRepository)
        {
            this.historyRepository = historyRepository;
        }

        public async Task AddAsync(History history) =>
            await historyRepository.AddAsync(history);

        public async Task<IEnumerable<History>> GetAllAsync() =>
            await historyRepository.GetAllAsync();
    }
}
