﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // To check sentence is
            // palindrome or not
            static bool sentencePalindrome(String str)
            {
                int l = 0;
                int h = str.Length - 1;

                // Lowercase string
                str = str.ToLower();

                // Compares character until
                // they are equal
                while (l <= h)
                {

                    char getAtl = str[l];
                    char getAth = str[h];

                    // If there is another symbol
                    // in left of sentence
                    if (!(getAtl >= 'a' &&
                          getAtl <= 'z'))
                        l++;

                    // If there is another symbol 
                    // in right of sentence
                    else if (!(getAth >= 'a' &&
                               getAth <= 'z'))
                        h--;

                    // If characters are equal
                    else if (getAtl == getAth)
                    {
                        l++;
                        h--;
                    }

                    // If characters are not equal then
                    // sentence is not palindrome
                    else
                        return false;
                }

                // Returns true if sentence
                // is palindrome
                return true;
            }

            // Driver Code
            public static void Main()
            {
                String str = "Too hot to hoot.";
                if (sentencePalindrome(str))
                    Console.Write("Sentence is palindrome");
                else
                    Console.Write("Sentence is not" + " " +
                                                 "palindrome");
            }
        }
    }
    }
}
