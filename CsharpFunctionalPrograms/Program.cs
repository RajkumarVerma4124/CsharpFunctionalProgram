using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Welcome To The Csharp Functional Programs");

            while (true)
            {
                Console.Write("\n1: Flip Coin Program"+
                            "\n2: Leap Year Program"+
                            "\n3: Power Of a Number 2"+
                            "\n4: Harmonic Number"+
                            "\n5: Prime Factorization Number"+
                            "\n6: Compute Quotient And Remainder Of Given Number"+
                            "\n7: Swaping Of Two Numbers"+
                            "\n8: Check Even Or Odd"+
                            "\n9: Check Consonant And Vowel"+
                            "\n10: Greatest Of Three Numbers"+
                            "\n11: Exit"
                             );
                Console.Write("\nEnter a choice from above : ");
                int choice = int.Parse(Console.ReadLine());
                if (choice > 0 && choice < 12)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("FlipCoin Program");
                            Console.Write("Enter how many time you want to throw the coin : ");
                            int flipCount = int.Parse(Console.ReadLine());
                            FlipCoin.ThrowCoin(flipCount);
                            break;
                        case 2:
                            Console.Write("Enter a year to check if its a leap year : ");
                            int year = int.Parse(Console.ReadLine());
                            LeapYear.ChkLeapOrNot(year);
                            break;
                        case 3:
                            int powNum = Convert.ToInt32(args[0]);
                            if (powNum >= 0 && powNum < 31)
                            {
                                PowerOfNumber.GetPowerOfNum(powNum);
                            }
                            else
                            {
                                Console.WriteLine("Enter Number From 0 to 30");
                                Console.ReadLine();
                                continue;
                            }
                            break;
                        case 4:
                            Console.Write("Enter a range for harmonic number : ");
                            int range = int.Parse(Console.ReadLine());
                            HarmonicNumber.GetTotalHarmonicNum(range);
                            break;
                        case 5:
                            Console.Write("Enter a range for prime factorization number : ");
                            int primaRange = int.Parse(Console.ReadLine());
                            PrimeFactorization.GetPrimeFactors(primaRange);
                            break;
                        case 6:
                            Console.Write("Enter a number to get quotient and remainder : ");
                            int num = int.Parse(Console.ReadLine());
                            QuotientAndRemainder.ComputeQandR(num);
                            break;
                        case 7:
                            Console.Write("Enter The First Number :");
                            int SFNum = int.Parse(Console.ReadLine());
                            Console.Write("Enter The Second Number :");
                            int SSNum = int.Parse(Console.ReadLine());
                            SwapNumbers.SwapTwoNum(SFNum, SSNum);
                            break;
                        case 8:
                            Console.Write("Enter a num to check even or odd : ");
                            int numCheck = int.Parse(Console.ReadLine());
                            EvenOrOdd.CheckEvenOrOdd(numCheck);
                            break;
                        case 9:
                            Console.Write("Enter a character to check vowel and consonant : ");
                            char ch = char.Parse(Console.ReadLine());
                            VowelAndConsonant.CheckVowelOrConsonant(ch);
                            break;
                        case 10:
                            Console.Write("Enter the first number : ");
                            int fNumber = int.Parse(Console.ReadLine());
                            Console.Write("Enter the second number : ");
                            int sNumber = int.Parse(Console.ReadLine());
                            Console.Write("Enter the third number : ");
                            int tNumber = int.Parse(Console.ReadLine());
                            GreatestOfThreeNumbers.CheckThreeNum(fNumber, sNumber, tNumber);
                            break;
                        default:
                            Environment.Exit(0);
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("\nEnter a right choice");
                    continue;
                }
            }
        }
    }
}
