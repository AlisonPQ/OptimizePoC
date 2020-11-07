using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.Models
{
    public class ShipmentLoad
    {
        public int ShipmentLoadId { get; set; }
        public Shipment Shipment { get; set; }
        public Load Load { get; set; }
    }
}
