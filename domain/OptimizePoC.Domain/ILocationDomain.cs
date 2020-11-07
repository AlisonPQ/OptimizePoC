using OptimizePoC.Models;
using System.Collections.Generic;

namespace OptimizePoC.Domain
{
    public interface ILocationDomain
    {
        ICollection<Location> GetAllLocations();
    }
}
