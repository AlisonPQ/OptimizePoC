using OptimizePoC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.DataSource
{
    public interface ICityDao
    {
        ICollection<City> getCities();
    }
}
