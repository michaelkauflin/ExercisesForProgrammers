using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    public class Engine
    {
        private readonly string _bill;
        private readonly string _percentage;

        public Engine(string bill, string percentage)
        {
            Initialize(bill, percentage);
        }

        private void Initialize(string billAsString, string percentageAsString)
        {
            double bill = Convert.ToDouble(billAsString, NumberFormatInfo.InvariantInfo);
            double percentage = Convert.ToDouble(percentageAsString, NumberFormatInfo.InvariantInfo);

            Tip = bill/100*percentage;

            Total = bill + Tip;
        }

        public double Tip { get; private set; }
        public double Total { get; private set; }
    }
}
