using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_letter_counts
{
    class Program
    {
        static readonly string[] oneToNineteen = new string[] 
        {
            "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
            "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };
        static readonly string[] twentyToNinety = new string[] { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};

        static void Main()
        {
            var lettersCounter = 0;
            for (int i = 1; i <= 1000; i++)
            {
                lettersCounter += SpellTheNumber(i).Length;
            }
            Console.WriteLine(lettersCounter);
        }

        static string SpellTheNumber(int number)
        {
            return oneToNineteen[number / 1000] + (number >= 1000 ? "thousand" : "") + oneToNineteen[number / 100 % 10] + (number % 1000 / 100 != 0 ? "hundred" : "") + 
                (number % 100 == 0 ? "" : (number >= 100 ? "and" : ""  )+ (number % 100 >= 20 ? twentyToNinety[number % 100 / 10] + oneToNineteen[number % 100 % 10] : oneToNineteen[number % 100]));
        }
    }
}
