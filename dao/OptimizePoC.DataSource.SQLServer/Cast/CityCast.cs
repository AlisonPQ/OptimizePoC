using OptimizePoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.DataSource.SQLServer.Cast
{
    public class CityCast
    {
        public static City CastingCity(City city)
        {
            return new City
            {
                CityId = city.CityId,
                Name = city.Name
            };
        }
    }
}
