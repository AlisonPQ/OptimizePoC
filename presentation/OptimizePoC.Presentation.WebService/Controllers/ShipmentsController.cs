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
    public class ShipmentsController : ApiController
    {
        private IShipmentDomain shipmentDomain;

        public ShipmentsController()
        {
            shipmentDomain = ShipmentImpl.Build();
        }

        [EnableQuery]
        public Shipment Get(int id)
        {
            var response = shipmentDomain.GetShipment(id);
            return response;
        }

        [EnableQuery]
        public IList<Shipment> Get()
        {
            var response = shipmentDomain.GetShipments();
            return response;
            /*
            IList<Shipment> response = new List<Shipment>();
            IList<Request> requestList = new List<Request>();
            requestList.Add(
                new Request
                {
                    RequestId = 1,
                    Origin = new Location
                    {
                        LocationId = 1,
                    },
                    Destination = new Location
                    {
                        LocationId = 2,
                    }
                }
            );
            requestList.Add(
                new Request
                {
                    RequestId = 2,
                    Origin = new Location
                    {
                        LocationId = 1,
                    },
                    Destination = new Location
                    {
                        LocationId = 2,
                    }
                }
            );
            response.Add(new Shipment
            {
                ShipmentId = 1,
                Requests = requestList
            });
            response.Add(new Shipment
            {
                ShipmentId = 2,
                Requests = requestList
            });
            return response;
            */
        }
    }
}
