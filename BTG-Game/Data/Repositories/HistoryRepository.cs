using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class HistoryRepository : IHistoryRepository
    {
        private readonly DataContext dataContext;
        public HistoryRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task AddAsync(History history)
        {
            await dataContext.History.AddAsync(history);
            await dataContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<History>> GetAllAsync() =>
            await dataContext.History.AsNoTracking().ToListAsync();
    }
}
