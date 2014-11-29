using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProperyPricer.Models
{
    public class LeaseModels
    {
        public string TenantName { get; set; }
        public double InitialRent { get; set; }
        public DateTime LeaseStart { get; set; }
        public DateTime LeaseEnd { get; set; }
        public double Area { get; set; }
        public string Unit { get; set; }
    }
}