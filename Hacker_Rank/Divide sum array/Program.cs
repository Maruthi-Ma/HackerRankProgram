﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_sum_array
{
    class Program
    {
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            var result = 0;
            var count = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i; j < ar.Length - 1; j++)
                {
                    result = 0;
                    result = ar[i] + ar[j + 1];
                    if (result == k || result % k == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        static void Main(string[] args)
        {

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = divisibleSumPairs(n, k, ar);

            Console.WriteLine(result);
        }
    }
}
