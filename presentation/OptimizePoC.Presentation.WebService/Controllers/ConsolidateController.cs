using OptimizePoC.Domain;
using OptimizePoC.Domain.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;

namespace OptimizePoC.Presentation.WebService.Controllers
{
    public class ConsolidateController : ApiController
    {
        private IShipmentDomain shipmentDomain;

        public ConsolidateController()
        {
            shipmentDomain = ShipmentImpl.Build();
        }
        public string Consolidate()
        {
            return shipmentDomain.Consolidate();
        }
    }
}
