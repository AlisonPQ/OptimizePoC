using OptimizePoC.Models;
using System.Collections;
using System.Collections.Generic;

namespace OptimizePoC.Domain
{
    public interface ICityDomain
    {
        ICollection<City> GetCityList();
    }
}
