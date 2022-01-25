using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalPrograms
{
    public class EvenOrOdd
    {
        //Method to check even or odd number
        public static void CheckEvenOrOdd(int num)
        {
            string EoOresult = num % 2 == 0 ? "The num " + num + " is Even Number" : "The num " + num + " is Odd Number";
            Console.WriteLine(EoOresult);
            Console.ReadLine();
        }
    }
}
