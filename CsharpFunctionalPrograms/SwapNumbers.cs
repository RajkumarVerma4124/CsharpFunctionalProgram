using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalPrograms
{
    public class SwapNumbers
    {
        //Method to compute swap two numbers
        public static void SwapTwoNum(int i, int j)
        {
            // Suppose number are i = 5 and i = 6
            i *= j;     // i = (5 * 6) i.e 30
            j = i/j;  // j = 30/6 i.e = 5
            i /= j;     // i = 30/5 i.e = 6

            Console.WriteLine("After Swaping : "+i+" "+j);
            Console.ReadLine();
        }
    }
}
