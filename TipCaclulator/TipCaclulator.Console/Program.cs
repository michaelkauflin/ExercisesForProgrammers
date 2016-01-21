
using System.Globalization;
using TipCalculator;

namespace TipCaclulator.Console
{
    class Program
    {
        static void Main()
        {
            System.Console.Write("What is the bill? $");
            string bill = System.Console.ReadLine();

            System.Console.Write("What is the tip percentage? ");
            string percentage = System.Console.ReadLine();

            var engine = new Engine(bill, percentage);

            System.Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "The tip is ${0:0.00}", engine.Tip));
            System.Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "The total is ${0:0.00}", engine.Total));

            System.Console.ReadLine();
        }
    }
}
