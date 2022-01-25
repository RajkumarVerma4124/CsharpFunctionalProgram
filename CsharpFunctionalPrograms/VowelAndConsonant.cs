using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalPrograms
{
    public class VowelAndConsonant
    {
        //Method to check the vowels or consonant
        public static void CheckVowelOrConsonant(char ch)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                Console.WriteLine(ch+" is vowel");
            else
                Console.WriteLine(ch+" is consonant");
        }
    }
}
