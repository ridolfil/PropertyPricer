using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProperyPricer.Models
{
    public class LeaseModels
    {
        public string TenantName { get; set; }
        [DisplayFormat(DataFormatString="{0:C}")]
        public double InitialRent { get; set; }
        [DisplayFormat(DataFormatString="{0:MMM yy}")]
        public DateTime LeaseStart { get; set; }
        [DisplayFormat(DataFormatString = "{0:MMM yy}")]
        public DateTime LeaseEnd { get; set; }
        [DisplayFormat(DataFormatString = "{0} sqm")]
        public double Area { get; set; }
        public string Unit { get; set; }
    }
}