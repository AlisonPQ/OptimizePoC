using OptimizePoC.DataSource.SQLServer.Cast;
using OptimizePoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.DataSource.SQLServer
{
    public class RequestDao : SessionFactory, IRequestDao
    {
        public string CreateRequest(int OriginId, int DestinationId)
        {
            try
            {
                using (var session = sessionFactory.OpenSession()) { }
                using (var tx = session.BeginTransaction())
                {
                    Request request = new Request
                    {
                        Origin = new Location { LocationId = OriginId },
                        Destination = new Location { LocationId = DestinationId },
                        Status = 0,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    };
                    session.Save(request);
                    tx.Commit();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return "Request has been added";
        }

        public IList<Request> GetRequests()
        {
            IList<Request> requests = new List<Request>();
            using (var session = sessionFactory.OpenSession()) { }

            using (var tx = session.BeginTransaction())
            {
                requests = session.CreateCriteria<Request>().List<Request>();
                tx.Commit();
            }
            return RequestCast.CastingRequestList(requests);
        }

        public Request GetRequest(int requestId)
        {
            try
            {
                Request request;
                using (var tx = session.BeginTransaction())
                {
                    request = (Request) session.Load(typeof(Request), requestId);
                }
                return RequestCast.CastingRequest(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Request> GetAvailableRequestList()
        {
            try
            {
                IList<Request> requests = new List<Request>();
                using (var session = sessionFactory.OpenSession()) { }

                using (var tx = session.BeginTransaction())
                {
                    requests = session.QueryOver<Request>()
                        .WhereRestrictionOn(x => x.Status).IsLike(0).List<Request>();
                }
                return RequestCast.CastingRequestList(requests);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean IsEqualLocation(Request request1, Request request2)
        {
            if(request1.Origin.LocationId == request2.Origin.LocationId
                && request1.Origin.LocationId == request2.Origin.LocationId)
                return true;
            return false;
        }

        
    }
}
