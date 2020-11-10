using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.Models
{
    public class Request
    {
        public virtual int RequestId { get; set; }
        public virtual Location Origin { get; set; }
        public virtual Location Destination { get; set; }
        public virtual int Status { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual DateTime UpdatedAt { get; set; }
    }
}
