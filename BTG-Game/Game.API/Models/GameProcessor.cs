using Application.DTOs;
using Application.Enums;
using Game.API.Builders;
using System.Linq;

namespace Game.API.Models
{
    public class GameProcessor
    {
        private readonly GameDTO game;
        private readonly GameResult gameResult;
        public GameProcessor(GameDTO game)
        {
            this.game = game;

            gameResult = new GameResult
            {
                FirstPlayerElement = game.FirstPlayerElement,
                FirstPlayerName = game.FirstPlayerName,
                SecondPlayerElement = game.SecondPlayerElement,
                SecondPlayerName = game.SecondPlayerName
            };
        }
        public GameResult Process()
        {
            var builder = new ElementBuilder();
            var firstPlayerElement = builder.BuildElementByName(game.FirstPlayerElement);
            var secondPlayerElement = builder.BuildElementByName(game.SecondPlayerElement);

            if (game.FirstPlayerElement.Equals(game.SecondPlayerElement))
            {
                gameResult.GameResultType = GameResultType.Draw;
                gameResult.ResultMessage = $"O jogo empatou, ambos selecionaram o mesmo elemento.";
            }
            else if (firstPlayerElement.WinsFrom.Select(e => e.GetType()).Contains(secondPlayerElement.GetType()))
            {
                gameResult.GameResultType = GameResultType.FirstPlayerWon;
                gameResult.ResultMessage = $"O jogador 1 ({game.FirstPlayerName}) venceu, porque {game.FirstPlayerElement} vence {game.SecondPlayerElement}!";
            }
            else
            {
                gameResult.GameResultType = GameResultType.SecondPlayerWon;
                gameResult.ResultMessage = $"O jogador 2 ({game.SecondPlayerName}) venceu, porque {game.SecondPlayerElement} vence {game.FirstPlayerElement}!";
            }

            return gameResult;
        }
    }
}
