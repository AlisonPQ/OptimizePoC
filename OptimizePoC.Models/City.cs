﻿using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizePoC.Models
{
    public class City
    {
        public City()
        {
            //Locations = new List<Location>();
        }
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        //public virtual IList<Location> Locations { get; set; }
    }
}
