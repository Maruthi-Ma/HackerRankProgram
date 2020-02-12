using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiful_Days_at_the_Movies
{
    class Program
    {
        static int beautifulDays(int i, int j, int k)
        {
            int reminder, result, count = 0;
            for (int m = i; m <= j; m++)
            {
                var rev = 0;
                var dummyDay = m;
                while (dummyDay != 0)
                {
                    reminder = dummyDay % 10;
                    rev *= 10 + reminder;
                    dummyDay /= 10;
                }
                result = (Math.Abs(m - rev));
                if (result % k == 0)
                {
                    count = count + 1;
                }
                Console.WriteLine(string.Format("The Value of Day is {0}, reversenumber is {1} ", m, rev));
            }
            return count;
        }


        static void Main(string[] args)
        {

            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int result = beautifulDays(i, j, k);

            Console.WriteLine(result);
        }
    }
}
