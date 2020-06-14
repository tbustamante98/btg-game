using Application.DTOs;
using Application.Enums;
using System.Text.Json.Serialization;

namespace Game.API.Models
{
    public class GameResult : GameDTO
    {
        [JsonIgnore]
        public GameResultType GameResultType { get; set; }
        public string ResultMessage { get; set; }
    }
}
