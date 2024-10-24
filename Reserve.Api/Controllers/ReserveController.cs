using Microsoft.AspNetCore.Mvc;
using Reserve.Core.Models.ApiClient.Reserve.GolClient;
using Reserve.Core.Models.Services.ExternalServices.Reserve;
using System.Net;

namespace Reserve.Api.Controllers
{
    public class ReserveController : Controller
    {
        private readonly IReserveApiService _reserveApiService;

        public ReserveController(IReserveApiService reserveApiService)
        {
            _reserveApiService = reserveApiService;
        }

        [HttpGet("/ObterDadosVoos/")]
        public async Task<IActionResult> ObterDadosVoos(string origem, string destino, DateTime data)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Um erro ocorreu ao validar as informações, por gentileza, tente novamente.");

                var resultado = await _reserveApiService.ObterDadosVooClienteGol(origem, destino, data);

                if (resultado == null)
                    return BadRequest("Não foram localizados dados de viagens, por gentileza, tente novamente.");

                return Ok(resultado);
            }

            catch (Exception ex)
            {
                return BadRequest("Um erro ocorreu durante o processamento das informações, tente novamente após alguns minutos.\r\n" +
                                 $"Detalhes Técnicos: {ex.Message}");
            }
        }
    }
}
