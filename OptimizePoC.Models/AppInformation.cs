using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.Models
{
    public class AppInformation
    {
        public string Name { get; set; }
        public string Status { get; set; }

        public AppInformation(string name, string status)
        {
            this.Name = name;
            this.Status = status;
        }
    }
}
