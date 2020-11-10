using OptimizePoC.Models;
using System.Collections;
using System.Collections.Generic;

namespace OptimizePoC.DataSource
{
    public interface ILocationDao
    {
        IList<Location> getLocations();
    }
}
