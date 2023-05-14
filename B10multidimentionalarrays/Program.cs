using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace B10multidimentionalarrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] singleDimensionArray = new string[3];

            string[,] twoDimensionArray = new string[4, 2];//8 elementów

            string[,,] threeDimensionalArray = new string[2,3,2];

            threeDimensionalArray[0, 0, 0] = "a";
            threeDimensionalArray[0,0,1] = "b";

            int length = threeDimensionalArray.Length;//2*3*2=12

            int firstDimentionSize = threeDimensionalArray.GetLength(1);//3

            twoDimensionArray[0, 0] = "A";
            twoDimensionArray[1, 0] = "B";
            twoDimensionArray[2, 0] = "C";
            twoDimensionArray[3, 0] = "D";

            twoDimensionArray[0, 1] = "E";
            twoDimensionArray[1, 1] = "F";
            twoDimensionArray[2, 1] = "G";
            twoDimensionArray[3, 1] = "H";

            Console.WriteLine("---- row wise----");

            for (int i = 0; i< twoDimensionArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionArray.GetLength(1); j++)
                    Console.Write(twoDimensionArray[i, j]+" ");

                Console.WriteLine();

            }
            Console.WriteLine("---- row wise----");
            for (int i = 0; i < twoDimensionArray.GetLength(1); i++)
            {
                for (int j = 0; j < twoDimensionArray.GetLength(0); j++)
                    Console.Write(twoDimensionArray[i, j] + " ");

                Console.WriteLine();
            }
           
            Console.ReadKey();
        }
    }
}
