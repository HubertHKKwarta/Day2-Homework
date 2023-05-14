using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B14listoflists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            List<List<string>> listoflists = new List<List<string>>();

           // List<List<List<List<string>>>>listoflistoflistoflistStrings = new


            listoflists.Add(new List<string>());
            listoflists[0].Add("A");
            listoflists[0].Add("B");

            listoflists.Add(new List<string>());
            listoflists[1].Add("A");
            listoflists[1].Add("B");
            listoflists[1].Add("C");

            listoflists.Add(new List<string>());
            listoflists[2].Add("A");
            listoflists[2].Add("B");
        }
    }
}
