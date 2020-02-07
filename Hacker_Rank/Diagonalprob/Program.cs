using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonalprob
{
    class Program
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            var diagonal = 0;
            var diagonal1 = 0;
            List<int> newlist = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                    {
                        diagonal += arr[i][j];
                        newlist.Add(diagonal);
                    }
                    if (i == arr.Count -j-1)
                    {
                        diagonal1 += arr[i][j];
                        newlist.Add(diagonal1);
                    }
                }
               
            }
            Console.WriteLine(string.Join(",", diagonal));
            Console.WriteLine(string.Join(",", diagonal1));
            
            
            //Method2

            //string diagonals1 = "";
            //string diagonals2 = "";

            //var j = 0;
            //foreach (List<int> item in arr)
            //{
            //    for (int i = 0; i < item.Count;)
            //    {
            //        diagonal += item[i + j];
            //        diagonal1 += item[item.Count - j - 1];
            //        diagonals1 = diagonals1 + item[i + j] + " + ";
            //        diagonals2 = diagonals2 + item[item.Count - j - 1] + " + ";
            //        break;

            //    }
            //    j++;
            //}
            //Console.WriteLine(diagonals1.Substring(0, diagonals1.Length - 1) + " : " + diagonal);
            //Console.WriteLine(diagonals2.Substring(0, diagonals2.Length - 1) + " : " + diagonal1);
            return Math.Abs(diagonal - diagonal1);

        }
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Program.diagonalDifference(arr);

            Console.WriteLine(result);
        }
    }
}
