﻿using OptimizePoC.DataSource;
using OptimizePoC.DataSource.SQLServer;
using OptimizePoC.Models;
using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.Domain.Impl
{
    public class LocationImpl : ILocationDomain
    {
        private static IApplicationContext ctx = ContextRegistry.GetContext();
        private ILocationDao locationDao = (LocationDao)ctx.GetObject("MyLocationDao");

        public static LocationImpl Build()
        {
            return new LocationImpl();
        }

        public IList<Location> GetAllLocations()
        {
            var locations = locationDao.getLocations();
            return locations;
        }
    }
}
