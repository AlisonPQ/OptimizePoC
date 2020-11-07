using OptimizePoC.DataSource;
using OptimizePoC.DataSource.SQLServer;
using OptimizePoC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.Domain.Impl
{
    public class LocationImpl : ILocationDomain
    {
        private ILocationDao locationDao;

        public LocationImpl(ILocationDao locationDao)
        {
            this.locationDao = locationDao;
        }
        public static LocationImpl Build()
        {
            return new LocationImpl(new LocationDao());
        }

        public ICollection<Location> GetAllLocations()
        {
            return locationDao.getLocations();
        }
    }
}
