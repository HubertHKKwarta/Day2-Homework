using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C02customclasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is variable and this variable referes to new object
            Calculator c = new Calculator();

            //WebClient wc = new WebClient();

            Calculator cl; // variable

            int g = c.CalculateSum(3, 4);
            int g2 = c.CalculateDifferent(4, 3);

            Console.WriteLine(g);
            Console.WriteLine(g2);
            Console.ReadKey();

        }
    }
}
