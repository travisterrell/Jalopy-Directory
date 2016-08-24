using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using treesap.Models;

namespace treesap.Services
{
    public interface IVehicleService
    {
        Task<IEnumerable<Vehicle>> Find();
    }
}
