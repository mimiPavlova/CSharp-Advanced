using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Drawing;

namespace _4._AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a program that reads one line
                of double prices separated by ", ".
                Print the prices with added VAT for 
                all of them.Format them to 2 signs 
                after the decimal point.The order of
                the prices must be the same.VAT is equal to 20% of the price.*/

            List<double> prises = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
               .Select(x => x+=(x*0.2)).
               ToList();


            prises.ForEach(p => Console.WriteLine($"{p:f2}"));
        }
    }
}
