using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B07lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cityArray = { "warsaw", "Berlin", "Paris" }; //arrays have fix length

            List<string> list = new List<string>();//empty list

            List<string> list2 = null;//this is null list so i cannot use it

            //list2.Add("xx")
            list.Add("warsaw");
            list.Add("berlin");
            ///
            list.Insert(1, "paris"); //warsaw paris berlin

           string city1 =  list[0];//1 element
           string city3 = list[list.Count -1];//last element

            list.RemoveAt(1);// remove second element bo zacyznamy od 0
            list.Remove("paris");// removes the first occurence of paris

            //list.RemoveAll()





        }
    }
}
