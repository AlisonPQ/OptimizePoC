using OptimizePoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.DataSource.SQLServer.Cast
{
    public class LocationCast
    {
        public static Location CastingLocation(Location location)
        {
            return new Location
            {
                LocationId = location.LocationId,
                Latitude = location.Latitude,
                Longitude = location.Longitude,
                Address = location.Address,
                City = CityCast.CastingCity(location.City),
            };
        }

        public static IList<Location> CastingLocationList(IList<Location> locations)
        {
            IList<Location> response = new List<Location>();
            foreach (var location in locations)
            {
                response.Add(CastingLocation(location));
            }
            return response;
        }
    }
}
