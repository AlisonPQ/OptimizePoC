using OptimizePoC.DataSource;
using OptimizePoC.DataSource.SQLServer;
using OptimizePoC.Models;
using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.Domain.Impl
{
    public class RequestImpl : IRequestDomain
    {
        private static IApplicationContext ctx = ContextRegistry.GetContext();
        private IRequestDao requestDao = (RequestDao)ctx.GetObject("MyRequestDao");

        public static RequestImpl Build()
        {
            return new RequestImpl();
        }

        public string CreateRequest(int OriginId, int DestinationId)
        {
            return requestDao.CreateRequest(OriginId, DestinationId);
        }

        public Request GetRequest(int requestId)
        {
            return requestDao.GetRequest(requestId);
        }

        public IList<Request> GetRequests()
        {
            var orders = requestDao.GetRequests();
            return orders;
        }
    }
}
