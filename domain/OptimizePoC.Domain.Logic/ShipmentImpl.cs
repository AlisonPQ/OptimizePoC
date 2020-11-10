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
    public class ShipmentImpl : IShipmentDomain
    {
        private static IApplicationContext ctx = ContextRegistry.GetContext();
        private IShipmentDao shipmentDao = (ShipmentDao)ctx.GetObject("MyShipmentDao");

        public static ShipmentImpl Build()
        {
            return new ShipmentImpl();
        }

        public string Consolidate()
        {
            return shipmentDao.Consolidate();
        }

        public Shipment GetShipment(int id)
        {
            return shipmentDao.GetShipment(id);
        }

        public IList<Shipment> GetShipments()
        {
            return shipmentDao.GetShipments();
        }
    }
}
