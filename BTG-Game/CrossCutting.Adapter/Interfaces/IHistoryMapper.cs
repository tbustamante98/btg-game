using Application.DTOs;
using Domain.Entities;
using System.Collections.Generic;

namespace CrossCutting.Adapter.Interfaces
{
    public interface IHistoryMapper
    {
        History ToEntity(HistoryDTO historyDTO);
        HistoryDTO ToDTO(History history);
        IEnumerable<HistoryDTO> ToHistoryDTOList(IEnumerable<History> histories);
    }
}
