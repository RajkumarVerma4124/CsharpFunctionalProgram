using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalPrograms
{
    public class GreatestOfThreeNumbers
    {
        //Method to get the greatest of three numbers 
        public static void CheckThreeNum(int fNum, int sNum, int tNum)
        {
            int result = tNum > (fNum > sNum ? fNum : sNum) ? tNum : (fNum > sNum ? fNum : sNum);
            Console.WriteLine("The Number " + result + " is the greatest");
            Console.ReadLine();
        }
    }
}
