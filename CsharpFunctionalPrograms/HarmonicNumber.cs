using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalPrograms
{
    public class HarmonicNumber
    {
        public static double i;

        //Method to compute the harmonic number
        public static void GetTotalHarmonicNum(int range)
        {
            double num = 0;
            if (range != 0)
            {
                for (i = 1; i <= range; i++)
                {
                    num = Math.Round(num + 1/i, 2);
                    Console.Write(" 1/" +i+ " = " +num);
                    if(i < range)
                        Console.Write("+");
                }
            }
            else
            {
                Console.WriteLine("Enter a number greater than zero");
                Console.ReadLine();
            }
        }
    }
}
