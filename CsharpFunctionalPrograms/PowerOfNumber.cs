using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalPrograms
{
    public class PowerOfNumber
    {
        public static int i;

        //Method to get power of a number
        public static void GetPowerOfNum(int powNum)
        {
            for (i = 0; i <= powNum; i++)
            {
                int ResOfPow = Convert.ToInt32(Math.Pow(2, i));
                Console.WriteLine("The Power Of 2 ^ "+i+" is : " + ResOfPow);
            }     
        }
    }
}
