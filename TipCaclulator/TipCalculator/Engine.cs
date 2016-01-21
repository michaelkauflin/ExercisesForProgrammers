using System;
using System.Collections.Generic;
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
            _bill = bill;
            _percentage = percentage;
        }

        public double Tip { get; private set; }
        public double Total { get; private set; }
    }
}
