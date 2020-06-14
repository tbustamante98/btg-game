using Application.DTOs;
using Application.Interfaces;
using CrossCutting.Adapter.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Game.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly IHistoryAppService historyService;
        private readonly IHistoryMapper historyMapper;
        public HistoryController(IHistoryAppService historyService, IHistoryMapper historyMapper)
        {
            this.historyService = historyService;
            this.historyMapper = historyMapper;
        }
        /// <summary>
        /// Retorna todo o histórico de jogos, ordenados do mais recente para o mais antigo.
        /// </summary>
        /// <response code="200">A listagem do histórico foi retornada com sucesso!</response>
        /// <response code="500">Ocorreu um erro inexperado ao listar o histórico.</response>
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<HistoryDTO>))]
        public async Task<IActionResult> Get()
        {
            try
            {
                var history = await historyService.GetAllAsync();

                return Ok(historyMapper.ToHistoryDTOList(history));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}