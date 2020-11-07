using OptimizePoC.DataSource;
using OptimizePoC.DataSource.SQLServer;
using System;
using System.Collections;
using Spring.Context;
using Spring.Context.Support;
using System.Collections.Generic;
using OptimizePoC.Models;

namespace OptimizePoC.Domain.Impl
{
    public class CityImpl : ICityDomain
    {
        private static IApplicationContext ctx = ContextRegistry.GetContext();
        private ICityDao cityDao = (CityDao)ctx.GetObject("MyCityDao");

        public static CityImpl Build()
        {
            return new CityImpl();
        }
        public ICollection<City> GetCityList()
        {
            return cityDao.getCities();
        }
    }
}
