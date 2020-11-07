﻿using OptimizePoC.Domain;
using OptimizePoC.Domain.Impl;
using OptimizePoC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;

namespace OptimizePoC.Presentation.WebService.Controllers
{
    public class LocationsController : ApiController
    {
        private ILocationDomain locationDomain;

        public LocationsController()
        {
            this.locationDomain = LocationImpl.Build();
        }

        [EnableQuery]
        public ICollection<Location> Get()
        {
            return locationDomain.GetAllLocations();
        }
    }
}
