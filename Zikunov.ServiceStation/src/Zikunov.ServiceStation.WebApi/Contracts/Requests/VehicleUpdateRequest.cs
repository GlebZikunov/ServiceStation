using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zikunov.ServiceStation.Data.Enums;

namespace Zikunov.ServiceStation.WebApi.Contracts.Requests
{
    /// <summary>
    /// Vehicle update request.
    /// </summary>
    public class VehicleUpdateRequest
    {
        /// <summary>
        /// Brand.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Number.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Type.
        /// </summary>
        public VehicleType VehicleType { get; set; }
    }
}
