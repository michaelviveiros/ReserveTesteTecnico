using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Reserve.Core.Entities.ApiClient.Reserve.GolClient;
using Reserve.Core.Interfaces.ExternalServices.ReserveApiClient;
using Reserve.Core.Models.ApiClient.Reserve.GolClient;
using Reserve.Infrastructure.ApiClient.ExternalServices.Reserve.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Reserve.Infrastructure.ApiClient.ExternalServices.Reserve
{
    public class ReserveApiClient : IReserveApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ReserveSettings _reserveSettings;
        private readonly ILogger<ReserveApiClient> _logger;

        public ReserveApiClient(IHttpClientFactory httpClientFactory, IOptions<ReserveSettings> reserveSettings, ILogger<ReserveApiClient> logger)
        {
            _httpClientFactory = httpClientFactory;
            _reserveSettings = reserveSettings.Value;
            _logger = logger;
        }

        public async Task<Gol> ObterDadosVoos(DateTime data, string origem, string destino)
        {
            var client = _httpClientFactory.CreateClient();

            var dataFormatada = data.ToString("yyyy-MM-dd");

            var url = string.Concat(_reserveSettings.BaseUrl, $"origin={origem}&destination={destino}&date={dataFormatada}");

            var request = await client.GetAsync(url);

            if (!request.IsSuccessStatusCode)
                throw new Exception("Um erro ocorreu ao tentar obter os dados dos voos");

            var response = await request.Content.ReadAsStringAsync();

            var voosContent = JsonConvert.DeserializeObject<Gol>(response);

            return voosContent;
        }
    }
}
