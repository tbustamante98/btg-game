using Application.DTOs;
using Application.Enums;
using CrossCutting.Adapter.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrossCutting.Adapter.Mappers
{
    public class HistoryMapper : IHistoryMapper
    {
        public HistoryDTO ToDTO(History history)
        {
            return new HistoryDTO
            {
                Id = history.Id,
                GameResultType = (GameResultType)Enum.Parse(typeof(GameResultType), history.GameResult),
                FirstPlayerName = history.FirstPlayerName,
                FirstPlayerElement = history.FirstPlayerElement,
                SecondPlayerName = history.SecondPlayerName,
                SecondPlayerElement = history.SecondPlayerElement,
                GameDate = history.GameDate
            };
        }

        public History ToEntity(HistoryDTO historyDTO)
        {
            return new History
            {
                Id = historyDTO.Id,
                GameResult = historyDTO.GameResultType.ToString(),
                FirstPlayerName = historyDTO.FirstPlayerName,
                FirstPlayerElement = historyDTO.FirstPlayerElement,
                SecondPlayerName = historyDTO.SecondPlayerName,
                SecondPlayerElement = historyDTO.SecondPlayerElement,
                GameDate = historyDTO.GameDate
            };
        }

        public IEnumerable<HistoryDTO> ToHistoryDTOList(IEnumerable<History> histories) =>
            histories.Select(h => ToDTO(h));
    }
}
