using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_DIgit
{
    class Reversenumber
    {
        static void numberReverse()
        {
            Console.WriteLine("Enter the number");
            var inputnumber = Convert.ToInt32(Console.ReadLine());
            var reminder = 0;
            var rev = 0;
            while (inputnumber != 0)
            {
                reminder = inputnumber % 10;
                rev = rev * 10 + reminder;
                inputnumber = inputnumber / 10;
            }
            Console.WriteLine(rev);
        }

    }


    class Reversename
    {
        static void nameReverse()
        {
            Console.WriteLine("Enter the number");
            var inputname = Console.ReadLine().ToLower();
            StringBuilder sb = new StringBuilder();
            for (int i = inputname.Length - 1; i >= 0; i++)
            {
                sb.Append(inputname[i]);
            }
            Console.WriteLine(sb);

            //To check the Wheather palindrome or not
            if (inputname == sb.ToString())
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
    }
}
