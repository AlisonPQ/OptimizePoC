using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimizePoC.Models;

namespace OptimizePoC.DataSource
{
    public interface IHealthInfoDao
    {
        AppInformation GetAppInfo();
    }
}
