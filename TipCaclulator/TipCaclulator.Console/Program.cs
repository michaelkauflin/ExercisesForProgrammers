
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

            System.Console.WriteLine("The tip is $" + engine.Tip);
            System.Console.WriteLine("The total is $" + engine.Total);

            System.Console.ReadLine();
        }
    }
}
