using OptimizePoC.DataSource.SQLServer.Cast;
using OptimizePoC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace OptimizePoC.DataSource.SQLServer
{
    public class LocationDao : SessionFactory, ILocationDao
    {
        public IList<Location> getLocations()
        {
            IList<Location> locations = new List<Location>();
            using (var session = sessionFactory.OpenSession()) { }

            using (var tx = session.BeginTransaction())
            {
                locations = session.CreateCriteria<Location>().List<Location>();
                tx.Commit();
            }
            return LocationCast.CastingLocationList(locations);
        }
    }
}
