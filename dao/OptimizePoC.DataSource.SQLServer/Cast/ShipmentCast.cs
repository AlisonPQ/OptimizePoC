using OptimizePoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.DataSource.SQLServer.Cast
{
    public class ShipmentCast
    {
        public static Shipment CastingShipment(Shipment shipment)
        {
            return new Shipment
            {
                ShipmentId = shipment.ShipmentId,
                Requests = RequestCast.CastingRequestList(shipment.Requests)
            };
        }
        public static IList<Shipment> CastingShipmentList(IList<Shipment> shipments)
        {
            IList<Shipment> response = new List<Shipment>();
            foreach (var shipment in shipments)
            {
                response.Add(CastingShipment(shipment));
            }
            return response;
        }
    }
}
