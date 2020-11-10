using OptimizePoC.Domain;
using OptimizePoC.Domain.Impl;
using OptimizePoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;

namespace OptimizePoC.Presentation.WebService.Controllers
{
    public class OrdersController : ApiController
    {
        private IRequestDomain requestDomain;

        public OrdersController()
        {
            requestDomain = RequestImpl.Build();
        }

        [EnableQuery]
        public IList<Request> Get()
        {
            var response = requestDomain.GetRequests();
            return response;
        }

        public string CreateRequest([FromBody] Request request)
        {
            var response = requestDomain.CreateRequest(request.Origin.LocationId, request.Destination.LocationId);
            return response;
        }

        [EnableQuery]
        public Request Get(int id)
        {
            var request = requestDomain.GetRequest(id);
            return request;
        }
    }
}
