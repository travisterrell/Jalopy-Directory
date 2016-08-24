using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treesap.Models
{
    public class VehicleViewModel
    {
        public Vehicle Vehicle { get; set; }
        public IEnumerable<Models.Vehicle> Vehicles { get; set; }
    }
}
