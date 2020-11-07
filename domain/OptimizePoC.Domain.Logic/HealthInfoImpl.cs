using OptimizePoC.DataSource;
using OptimizePoC.DataSource.Memory;
using OptimizePoC.Models;
using Spring.Context;
using Spring.Context.Support;

namespace OptimizePoC.Domain.Impl
{
    public class HealthInfoImpl : IHealthInfoDomain
    {
        private static IApplicationContext applicationContext = ContextRegistry.GetContext();
        private IHealthInfoDao healthInfoDao = (HealthInfoDao) applicationContext.GetObject("MyHealthInfoDao");

        public AppInformation GetHealth()
        {
            return healthInfoDao.GetAppInfo();
        }

        public static HealthInfoImpl BuildFromMemory()
        {
            return new HealthInfoImpl();
        }
    }
}
