using OptimizePoC.Models;
using System.Collections.Generic;

namespace OptimizePoC.DataSource
{
    public interface ILocationDao
    {
        ICollection<Location> getLocations();
    }
}
