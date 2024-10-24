using Reserve.Core.Models.ApiClient.Reserve.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve.Core.Models.ApiClient.Reserve.LatamClient
{
    public class LatamDTO : ReserveBaseClientDTO
    {
        public string Carrier { get; set; }
    }
}
