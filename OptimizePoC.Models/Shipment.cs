using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.Models
{
    public class Shipment
    {
        public virtual int ShipmentId { get; set; }
        public virtual IList<Request> Requests { get; set; }
    }
}
