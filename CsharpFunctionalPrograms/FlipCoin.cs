using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalPrograms
{
    public class FlipCoin
    {
        //Initializing And Declaring Static Variables   
        private static int headCount = 0;
        private static int tailCount = 0;
        private static double headPercent;
        private static double tailPercent;
        private static Random random = new Random();
        private static double checkCoin;
        
        //Method To Get The Percentage Of Heads And Tails
        public static void ThrowCoin(int flipCount)
        {
            Console.WriteLine("The Coin Is Flipped : ");
            int tempCount = flipCount;
            while(tempCount > 0)
            {
                checkCoin = Math.Round(random.NextDouble(),2);
                if(checkCoin < 0.5)
                {
                    tailCount++;
                    tempCount--;
                }
                else
                {
                    headCount++;
                    tempCount--;
                }
            }
            headPercent = (headCount * 100) / flipCount;
            tailPercent = (tailCount * 100) / flipCount;
            int resPercent = headPercent.CompareTo(tailPercent); 
            if(resPercent > 0)
                Console.WriteLine("Head Won With Percentage : " + headPercent);
            else if(resPercent < 0)
                Console.WriteLine("Tail Won With Percentage : " + tailPercent);
            else
                Console.WriteLine("Both Won With Percentage : " + tailPercent+"/"+headPercent);
            Console.ReadLine();
        }
    }
}
