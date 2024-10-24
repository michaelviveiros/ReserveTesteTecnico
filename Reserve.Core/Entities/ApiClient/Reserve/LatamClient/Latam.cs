using Reserve.Core.Entities.ApiClient.Reserve.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve.Core.Entities.ApiClient.Reserve.LatamClient
{
    public class Latam : ReserveBaseClient
    {
        public string Carrier { get; set; }
    }
}
