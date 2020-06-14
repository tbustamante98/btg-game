using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IHistoryAppService
    {
        Task AddAsync(History history);
        Task<IEnumerable<History>> GetAllAsync();
    }
}
