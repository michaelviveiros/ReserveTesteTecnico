using Reserve.Core.Models.ApiClient.Reserve.GolClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve.Core.Models.Services.ExternalServices.Reserve
{
    public interface IReserveApiService
    {
        Task<GolDTO> ObterDadosVooClienteGol(string origem, string destino, DateTime data);
    }
}
