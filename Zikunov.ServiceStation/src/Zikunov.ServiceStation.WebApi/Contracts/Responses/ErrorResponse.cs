using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zikunov.ServiceStation.WebApi.Contracts.Responses
{
    /// <summary>
    /// Error response.
    /// </summary>
    public class ErrorResponse<T>
    {
        /// <summary>
        /// Message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Errors.
        /// </summary>
        public IEnumerable<T> Errors { get; set; }
    }
}
