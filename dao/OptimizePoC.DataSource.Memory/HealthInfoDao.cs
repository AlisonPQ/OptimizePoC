using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimizePoC.Models;

namespace OptimizePoC.DataSource.Memory
{
    public class HealthInfoDao : IHealthInfoDao
    {
        private AppInformation AppInformation;

        public HealthInfoDao()
        {
            this.AppInformation = new AppInformation("Optimize PoC 2020", "Up");
        }

        public AppInformation GetAppInfo()
        {
            Console.WriteLine("Getting application information");
            return this.AppInformation;
        }
    }
}
