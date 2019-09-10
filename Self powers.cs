using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_powers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SummarizeSelfPowers(1000));//9110846700
        }

        static long SummarizeSelfPowers(int n)
        {
            var result = 0l;
            for (int i = 1; i <= n; i++)
            {
                var product = (long)i;
                for (int j = 2; j <= i; j++)
                {
                    product = (product * i) ;
                }
                result = (result + product) % 10000000000;
            }
            return result;
        }
    }
}
