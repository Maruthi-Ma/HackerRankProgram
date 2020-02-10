using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Conversion
{
    class Program
    {
        /*
      * Complete the timeConversion function below.
      */
        static string timeConversion(string s)
        {
            var midday = s.Substring(s.Length - 2, 2);
            var time = s.Substring(0, s.Length - 2);
            var timearr = s.Split(':');
            var hour = timearr[0];
            var min = timearr[1];
            var sec = timearr[2];
            if (midday == "PM".ToLower())
            {
                if (hour !="12")
                {
                    hour = (int.Parse(hour) + 12).ToString();
                }
            }
            else
            {
                if (hour =="12")
                {
                    hour = "00";
                }
            }
            string timeFormate = hour + ":" + min + ":" + sec ;
            return timeFormate;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);

            Console.WriteLine(result);

        }
    }
}
