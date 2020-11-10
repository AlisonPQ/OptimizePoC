using NHibernate;
using OptimizePoC.DataSource.SQLServer.Cast;
using OptimizePoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.DataSource.SQLServer
{
    public class ShipmentDao : SessionFactory, IShipmentDao
    {
        public Shipment GetShipment(int shipmentId)
        {
            try
            {
                Shipment shipment;
                using (var tx = session.BeginTransaction())
                {
                    shipment = (Shipment)session.Load(typeof(Shipment), shipmentId);
                    //shipment = (Shipment) session.Get<Shipment>(shipmentId);
                }
                return ShipmentCast.CastingShipment(shipment);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Shipment> GetShipments()
        {
            IList<Shipment> shipments = new List<Shipment>();
            using (var session = sessionFactory.OpenSession()) { }

            using (var tx = session.BeginTransaction())
            {
                shipments = session.CreateCriteria<Shipment>().List<Shipment>();
                tx.Commit();
            }
            return ShipmentCast.CastingShipmentList(shipments);
        }
    }
}
