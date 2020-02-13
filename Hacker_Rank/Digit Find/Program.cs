using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit_Find
{
    class Program
    {
        static int findDigits(int n)
        {
            var data = n;
            var reminder = 0;
            var rever = 0;
            var count = 0;
            while (data > 0)
            {
                reminder = data % 10;
                rever = rever * 10 + reminder;
                data = data / 10;
                if (reminder > 0 && n % reminder == 0)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);

                Console.WriteLine(result);
            }
        }
    }
}
