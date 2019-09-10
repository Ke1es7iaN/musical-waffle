using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicographic_permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 1; i < 1000000; i++) GetNextPermutation(array);
            for (int l = 0; l < array.Length; l++) Console.Write(array[l]);//2783915460
            Console.WriteLine();
        }

        static void GetNextPermutation(int[] arr)
        {
            var index = 0;

            for (int i = 1; i < arr.Length; i++)
                if (arr[i-1] < arr[i]) index = i;

            for (int j = arr.Length - 1; j >= index; j--)
                if (arr[j] > arr[index - 1])
                {
                    var temp = arr[j];
                    arr[j] = arr[index - 1];
                    arr[index - 1] = temp;
                    break;
                }
            for (int k = index; k < index + (arr.Length - index)/2; k++)
            {
                var temp = arr[k];
                arr[k] = arr[arr.Length - 1 - k + index];
                arr[arr.Length - 1 - k + index] = temp;
            }
        }
    }
}
