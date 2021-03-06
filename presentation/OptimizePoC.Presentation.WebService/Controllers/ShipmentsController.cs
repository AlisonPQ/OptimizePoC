﻿using OptimizePoC.Domain;
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
        }
    }
}
