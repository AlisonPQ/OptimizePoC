using NHibernate;
using OptimizePoC.DataSource.SQLServer.Cast;
using OptimizePoC.Models;
using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.DataSource.SQLServer
{
    public class ShipmentDao : SessionFactory, IShipmentDao
    {
        private RequestDao requestDao = new RequestDao();

        public string Consolidate()
        {
            IList<Request> availableRequestList = requestDao.GetAvailableRequestList();

            while (availableRequestList.Count > 0)
            {
                Request firstRequest = availableRequestList[0];
                availableRequestList.RemoveAt(0);
                var copyList = availableRequestList;

                Request auxRequest = null;
                IList<Request> requestsToAddToAShipment = new List<Request>();
                requestsToAddToAShipment.Add(firstRequest);

                for (int i = 0; i < availableRequestList.Count; i++)
                {
                    auxRequest = availableRequestList[i];
                    if (requestDao.IsEqualLocation(firstRequest, auxRequest))
                    {
                        requestsToAddToAShipment.Add(auxRequest);
                        copyList.RemoveAt(i);
                    }
                }
                availableRequestList = copyList;
                CreateShipment(requestsToAddToAShipment);
            }

            return "Consolidated!";
        }

        public void CreateShipment(IList<Request> requestsToAddToAShipment) 
        {
            try
            {
                using (var session = sessionFactory.OpenSession()) { }
                using (var tx = session.BeginTransaction())
                {
                    Shipment shipment = new Shipment
                    {
                        Status = 0,
                        Requests = requestsToAddToAShipment
                    };
                    session.Save(shipment);

                    foreach (var request in requestsToAddToAShipment)
                    {
                        request.Status = 1;
                        session.Update(request);
                    }
                    tx.Commit();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Shipment GetShipment(int shipmentId)
        {
            try
            {
                Shipment shipment;
                using (var tx = session.BeginTransaction())
                {
                    shipment = (Shipment)session.Load(typeof(Shipment), shipmentId);
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
