using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Zikunov.ServiceStation.Data.Enums;

namespace Zikunov.ServiceStation.WebApi.Contracts.Requests
{
    /// <summary>
    /// Vehicle create request.
    /// </summary>
    public class VehicleCreateRequest
    {
        /// <summary>
        /// Brand.
        /// </summary>
        [Required]
        public string Brand { get; set; }

        /// <summary>
        /// Number.
        /// </summary>
        [Required]
        public string Number { get; set; }
    }
}
