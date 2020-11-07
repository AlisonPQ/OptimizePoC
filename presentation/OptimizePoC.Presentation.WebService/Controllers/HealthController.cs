using OptimizePoC.Domain;
using OptimizePoC.Domain.Impl;
using OptimizePoC.Models;
using System.Web.Http;
using System.Web.Http.OData;
using Spring.Context;
using Spring.Context.Support;

namespace OptimizePoC.Presentation.WebService.Controllers
{
    public class HealthController : ApiController
    {
        private IHealthInfoDomain healthInfoDomain;

        public HealthController()
        {
            this.healthInfoDomain = HealthInfoImpl.BuildFromMemory();
        }

        [EnableQuery]
        public AppInformation Get()
        {
            var result = this.healthInfoDomain.GetHealth();
            return result;
        }
    }
}
