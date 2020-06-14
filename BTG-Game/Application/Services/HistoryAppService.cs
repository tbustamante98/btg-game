using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services
{
    public class HistoryAppService : IHistoryAppService
    {
        private readonly IHistoryService historyService;
        public HistoryAppService(IHistoryService historyService)
        {
            this.historyService = historyService;
        }

        public async Task AddAsync(History history) =>
            await historyService.AddAsync(history);

        public async Task<IEnumerable<History>> GetAllAsync() =>
            (await historyService.GetAllAsync()).OrderByDescending(h => h.Id).AsEnumerable();
    }
}
