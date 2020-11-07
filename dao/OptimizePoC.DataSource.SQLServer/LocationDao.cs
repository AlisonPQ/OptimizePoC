using OptimizePoC.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OptimizePoC.DataSource.SQLServer
{
    public class LocationDao : SessionFactory, ILocationDao
    {
        public ICollection<Location> getLocations()
        {
            ICollection<Location> locations = new List<Location>();
            using (var session = sessionFactory.OpenSession()) { }

            using (var tx = session.BeginTransaction())
            {
                locations = session.CreateCriteria<Location>().List<Location>();
                tx.Commit();
            }
            return locations;
        }
    }
}
