using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lattice_paths
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetNumberOfWays(20));//407575348
        }

        static int GetNumberOfWays(int n)
        {
            var dp = new int[n + 1, n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                dp[i, 0] = 1;
                dp[0, i] = 1;
            }

            for (int i = 1; i < n + 1; i++)
                for (int j = 1; j < n + 1; j++)
                    dp[i, j] = dp[i, j - 1] + dp[i - 1, j];

            return dp[n, n];
        }
    }
}
