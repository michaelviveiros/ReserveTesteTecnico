using Reserve.Core.Entities.ApiClient.Reserve.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve.Core.Entities.ApiClient.Reserve.GolClient
{
    public class Gol : ReserveBaseClient
    {
        public string Carrier { get; set; }
    }
}
