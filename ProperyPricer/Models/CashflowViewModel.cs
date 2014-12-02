using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProperyPricer.Models
{
    public class CashflowViewModel
    {
        [DisplayFormat(DataFormatString="{0:MMM yyyy}")]
        public DateTime Date { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Amount { get; set; }
    }
}