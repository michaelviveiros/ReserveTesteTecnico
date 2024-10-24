using Reserve.Core.Entities.ApiClient.Reserve.GolClient;
using Reserve.Core.Models.ApiClient.Reserve.GolClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve.Core.Interfaces.ExternalServices.ReserveApiClient
{
    public interface IReserveApiClient
    {
        Task<Gol> ObterDadosVoos(DateTime data, string origem, string destino);
    }
}
