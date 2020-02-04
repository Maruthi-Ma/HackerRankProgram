using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraysum
{
    class Program
    {
        static int simpleArraySum(int[] ar)
        {
            var sum = 0;
            foreach (var item in ar)
            {
                sum += item;
            }
            return sum;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array size");
            int arCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an Elements of array");
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = simpleArraySum(ar);

            Console.WriteLine("The sum of array is "+result);

           
        }
    }
}
