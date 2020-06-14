using Application.DTOs;
using Application.Interfaces;
using CrossCutting.Adapter.Interfaces;
using Game.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Game.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IHistoryAppService historyService;
        private readonly IHistoryMapper historyMapper;

        public GameController(IHistoryAppService historyService, IHistoryMapper historyMapper)
        {
            this.historyService = historyService;
            this.historyMapper = historyMapper;
        }

        /// <summary>
        /// Processa as entradas enviadas como parâmetro e retorna qual jogador é o vencedor da partida.
        /// </summary>
        /// <param name="game">Objeto que contém os nomes e elementos selecionados pelos dois jogadores.</param>
        /// <response code="200">O resultado do jogo foi processado com sucesso!</response>
        /// <response code="400">A requisição foi enviada com valores inválidos. Analise a aba "Schemes" para obter exemplos.</response>
        /// <response code="500">Ocorreu um erro inexperado ao processar o jogo.</response>
        [HttpPost]
        [ProducesResponseType(200, Type = typeof(GameResult))]
        public async Task<IActionResult> Post([FromForm] GameDTO game)
        {
            try
            {
                GameProcessor processor = new GameProcessor(game);
                GameResult gameResult = processor.Process();

                HistoryDTO historyDTO = new HistoryDTO
                {
                    GameResultType = gameResult.GameResultType,
                    FirstPlayerName = game.FirstPlayerName,
                    FirstPlayerElement = game.FirstPlayerElement,
                    SecondPlayerName = game.SecondPlayerName,
                    SecondPlayerElement = game.SecondPlayerElement
                };

                await historyService.AddAsync(historyMapper.ToEntity(historyDTO));
                return Ok(gameResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}