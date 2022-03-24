using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zikunov.ServiceStation.WebApi.Settings
{
    /// <summary>
    /// App settings.
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// Secret key for Jwt generation.
        /// </summary>
        public string Secret { get; set; }
    }
}
