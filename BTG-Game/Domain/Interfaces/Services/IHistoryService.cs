using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IHistoryService
    {
        Task AddAsync(History history);
        Task<IEnumerable<History>> GetAllAsync();
    }
}
