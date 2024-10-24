using AutoMapper;
using Microsoft.Extensions.Logging;
using Reserve.Core.Interfaces.ExternalServices.ReserveApiClient;
using Reserve.Core.Models.ApiClient.Reserve.GolClient;
using Reserve.Core.Models.Services.ExternalServices.Reserve;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve.Services.Services.ExternalServices.Reserve
{
    public class ReserveApiService : IReserveApiService
    {
        private readonly IReserveApiClient _reserveApiClient;
        private readonly ILogger<ReserveApiService> _logger;
        private readonly IMapper _mapper;

        public ReserveApiService(IReserveApiClient reserveApiClient, ILogger<ReserveApiService> logger, IMapper mapper)
        {
            _reserveApiClient = reserveApiClient;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<GolDTO> ObterDadosVooClienteGol(string origem, string destino, DateTime data)
        {
            try
            {
                //Seria passado no controller da camada de Reserve.Api
                origem += "Rio%20de%20Janeiro";
                destino += "São%20Paulo";

                var resultado = await _reserveApiClient.ObterDadosVoos(DateTime.Now, origem, destino);

                var voosDTO = _mapper.Map<GolDTO>(resultado);

                return voosDTO;
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "Um erro ocorreu ao executar o método ObterDadosVooClienteGol - Data/Hora: {DateTime}",
                        DateTime.UtcNow);

                throw new Exception(ex.Message);
            }
        }
    }
}
