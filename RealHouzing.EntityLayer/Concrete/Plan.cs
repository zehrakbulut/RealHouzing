﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.EntityLayer.Concrete
{
    public class Plan
    {
        public int PlanID { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public decimal Fee { get; set; }
        public DateTime Time { get; set; }
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public string Chance { get; set; }
    }
}
