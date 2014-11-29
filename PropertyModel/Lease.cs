using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyModel
{
    public class Lease
    {
        public Lease(DateTime start, DateTime end, double rent)
        {
            LeaseStart = new DateTime(start.Year,start.Month,1);
            LeaseEnd = end;
            InitialRent = rent;

            leaseCF = new Cashflows();

            computeCF();

            ExitRent = leaseCF.getLast();
        }

        public string TenantName { get; set; }
        public DateTime LeaseStart { get; private set; }
        public DateTime LeaseEnd { get; private set; }
        public double InitialRent { get; private set; }
        public double ExitRent { get; private set; }

        public Cashflows getCashflows()
        {
            return leaseCF;
        }

        private Cashflows leaseCF;

        private void computeCF()
        {
            leaseCF.clear();
            DateTime current = LeaseStart;

            while (DateTime.Compare(current, LeaseEnd) < 0)
            {
                TimeSpan ts = current.AddMonths(1) - current;
                double currentRent = InitialRent/365*ts.Days;

                leaseCF.insertAmount(current, currentRent);

                current = current.AddMonths(1);
            }

        }
    }
}
