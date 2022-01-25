using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalPrograms
{
    public class PrimeFactorization
    {
        //Method to compute prime factors of given number
        public static void GetPrimeFactors(int numFact)
        {
            for (int i = 2; i <= numFact/i; i++)
            {
               while(numFact%i == 0)
               {
                    Console.WriteLine("i = " +i+ " factor = "+numFact);
                    numFact = numFact/i;
                    Console.WriteLine("Prime Factor is "+i);
               }
            }
            if (numFact > 1)
                Console.WriteLine("Prime Factor is "+numFact);
        }
    }
}
