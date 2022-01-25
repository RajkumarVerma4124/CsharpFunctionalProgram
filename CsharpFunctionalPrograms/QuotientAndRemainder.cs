using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalPrograms
{
    public class QuotientAndRemainder
    {
        //Method to compute quotient and remainder
        public static void ComputeQandR(int num)
        {
            int quotient = num / 10;
            int remainder = num % 10;
            Console.WriteLine("The Quotient is : {0} And Remainder Is : {1}",quotient, remainder);
        }
    }
}
