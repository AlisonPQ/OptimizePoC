using OptimizePoC.Models;

namespace OptimizePoC.Domain
{
    public interface IHealthInfoDomain
    {
        AppInformation GetHealth();
    }
}
