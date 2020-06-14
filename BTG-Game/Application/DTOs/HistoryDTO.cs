using Application.Enums;
using System;
using System.Text.Json.Serialization;

namespace Application.DTOs
{
    public class HistoryDTO
    {
        private GameResultType gameResultType;

        public int Id { get; set; }
        [JsonIgnore]
        public GameResultType GameResultType
        {
            get => gameResultType;
            set
            {
                gameResultType = value;
                GameResult = value.ToString();
            }
        }
        public string GameResult { get; set; }
        public string FirstPlayerName { get; set; }
        public string FirstPlayerElement { get; set; }
        public string SecondPlayerName { get; set; }
        public string SecondPlayerElement { get; set; }
        public DateTime GameDate { get; set; }
    }
}
