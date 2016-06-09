﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Largest
{
    public class Program
    {
        public static void Main(string[] args)
        /*{
            int counter = 0;
            int number = 0;
            int largest = 0;

            for (counter = 0; counter < 10; counter++) // loop in order to get inputs from the user
            {
                Console.Write("Give me the number ");
                number = Convert.ToInt32(Console.ReadLine());
                if (counter == 0) // the first input
                {
                    largest = number;
                }
                else
                {
                    if (number > largest) // from the second to last inputs
                    {
                        largest = number;
                    }
                }
            }                        
            Console.WriteLine("The largest number is {0}", largest);
        }
    }
}*/
        {
            int number = 0;
            int largest = int.MinValue; //refreshing the value of "largest" in order to avoid using the first if.
            int counter = 0;

            for (counter = 0; counter < 10; counter++)
            {
                Console.Write("Give me the number ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number > largest)
                {
                    largest = number;
                }
            }
            Console.WriteLine("The max number is {0}", largest);
        }
    }
}