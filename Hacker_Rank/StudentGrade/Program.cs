using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrade
{
    class Program
    {
        public static List<int> gradingStudents(List<int> grades)
        {
           var data = 0;
           List<int> Gradesdata = new List<int>();
            foreach (var grade in grades)
            {
                if (grade < 40 && grade + 2 < 40)
                {
                    data = grade;
                }
                else 
                {
                    var difference = grade % 5;
                    if (difference >= 3)
                    {
                        data = grade + (5 - difference);
                    }
                    else
                    {
                        data = grade;
                    }
                }
                Gradesdata.Add(data);
            }
           

            return Gradesdata;
        }



        public static void Main(string[] args)
        {

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Program.gradingStudents(grades);

            Console.WriteLine(String.Join("\n", result));

        }
    }
}
