using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zikunov.ServiceStation.BlazorApp.Models;

namespace Zikunov.ServiceStation.BlazorApp.Interfaces
{
    public interface IAuthenticationService
    {
        User User { get; }

        Task Initialize();

        Task Login(string username, string password);

        Task Logout();
    }
}
