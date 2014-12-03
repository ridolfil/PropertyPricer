using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyModel
{
    public class Cashflows
    {

        public Cashflows()
        {
            cf = new SortedDictionary<DateTime,double>();
        }

        public double getAmount(int month, int year)
        {
            double amt = 0;
            return amt;
        }

        public void insertAmount(DateTime dt, double amt)
        {
            cf.Add(dt, amt);
        }

        public double getLast()
        {
            return this.cf.Last().Value;
        }

        public void clear()
        {
            cf.Clear();
        }

        public static Cashflows operator+ (Cashflows firstCF, Cashflows secondCF)
        {
            Cashflows sum = new Cashflows();

            sum.cf = firstCF.cf;

            foreach (var item in secondCF.cf)
            {
                if (firstCF.cf.ContainsKey(item.Key)) sum.cf[item.Key] += item.Value;
                else sum.cf.Add(item.Key, item.Value);
            }

            return sum;
        }

        public List<string> toList()
        {
            List<string> l = new List<string>();

            foreach(var i in cf){
                string s = i.Key.ToString("MMM yyyy") + " " +i.Value;
                l.Add(s);
            }

            return l;
        }

        public IDictionary<DateTime, double> getCashflows()
        {
            IDictionary<DateTime, double> dic = cf;
            return dic;
        }

        private SortedDictionary<DateTime, double> cf;
    }
}
