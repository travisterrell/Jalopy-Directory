using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using treesap.Clients;

namespace treesap.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public static List<Vehicle> From(EdmondsResponse response)
        {
            var vehicles = new List<Vehicle>();

            foreach(var v in response.models)
            {
                vehicles.Add(new Vehicle
                {
                    Id = v.years.First().id,
                    Make = response.name,
                    Model = v.name,
                    Year = v.years.First().year
                }); 
            }

            return vehicles;
        }
    }
}