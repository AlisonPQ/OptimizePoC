using OptimizePoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.Domain
{
    public interface IRequestDomain
    {
        IList<Request> GetRequests();
        Request GetRequest(int orderId);
        string CreateRequest(int OriginId, int DestinationId);
    }
}
