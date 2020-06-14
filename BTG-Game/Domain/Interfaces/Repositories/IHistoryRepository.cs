using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IHistoryRepository
    {
        Task AddAsync(History history);
        Task<IEnumerable<History>> GetAllAsync();
    }
}
