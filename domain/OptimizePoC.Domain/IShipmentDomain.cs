using OptimizePoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.Domain
{
    public interface IShipmentDomain
    {
        IList<Shipment> GetShipments();
        Shipment GetShipment(int id);
        string Consolidate();
    }
}
