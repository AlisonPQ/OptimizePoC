using OptimizePoC.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OptimizePoC.DataSource.SQLServer
{
    public class CityDao : SessionFactory, ICityDao
    {
        public ICollection<City> getCities()
        {
            try
            {
                ICollection<City> cities = session.CreateCriteria(typeof(City)).List<City>();
                return cities;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
