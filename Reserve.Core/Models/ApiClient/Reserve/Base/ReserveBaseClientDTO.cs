using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve.Core.Models.ApiClient.Reserve.Base
{
    public class ReserveBaseClientDTO
    {
        public string FlightNumber { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime ArrivalDate { get; set; }

        public string OriginAirport { get; set; }

        public string DestinationAirport { get; set; }

        public string FarePrice { get; set; }
    }
}
