using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Zikunov.ServiceStation.Data.Enums;

namespace Zikunov.ServiceStation.WebApi.Contracts.Requests
{
    /// <summary>
    /// Service create request.
    /// </summary>
    public class ServiceCreateRequest
    { 
        /// <summary>
        /// Vehicle identifier.
        /// </summary>
        [Required]
        public int VehicleId { get; set; }

        /// <summary>
        /// Comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Start.
        /// </summary>
        [Required]
        public DateTime Start { get; set; }

        /// <summary>
        /// End.
        /// </summary>
        [Required]
        public DateTime End { get; set; }
    }
}
