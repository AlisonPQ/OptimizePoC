using OptimizePoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.DataSource.SQLServer.Cast
{
    public class RequestCast
    {
        public static Request CastingRequest(Request request)
        {
            if (request == null) return null;

            return new Request
            {
                RequestId = request.RequestId,
                Origin = LocationCast.CastingLocation(request.Origin),
                Destination = LocationCast.CastingLocation(request.Destination),
                Status = request.Status,
                CreatedAt = request.CreatedAt,
                UpdatedAt = request.UpdatedAt
            };
        }
        public static IList<Request> CastingRequestList(IList<Request> requests)
        {
            if (requests == null) return null;
            IList<Request> response = new List<Request>();
            foreach (var request in requests)
            {
                response.Add(CastingRequest(request));
            }
            return response;
        }
    }
}
