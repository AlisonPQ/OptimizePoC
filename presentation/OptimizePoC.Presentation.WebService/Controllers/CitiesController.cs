using OptimizePoC.Domain;
using OptimizePoC.Domain.Impl;
using OptimizePoC.Models;
using System.Collections;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.OData;
using System.Linq;

namespace OptimizePoC.Presentation.WebService.Controllers
{
    public class CitiesController : ApiController
    {
        private ICityDomain cityDomain;

        public CitiesController()
        {
            this.cityDomain = CityImpl.Build();
        }

        [EnableQuery]
        public IEnumerable<City> Get()
        {
            var cities = cityDomain.GetCityList();
            return cities;
        }
    }
}
