using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfowayINOUTRefparam
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhone { get; set; }
        public int TotalMarks { get; set; }

        public string calculateResult(int TotalMarks ,out string companyName)
        {
            companyName = "Cognizant!!";

            if (TotalMarks > 80)
            {
            return string.Format($"Student {StudentName} has been selected for next Round of Interview !!!");
          }
           else
           {
                return string.Format($"Student {StudentName} has been rejected for next Round of Interview !!!");
            }

        }

      /*  public string calculateResult(int TotalMarks, ref string companyName)
        {
            

            if (TotalMarks > 80)
            {
                return string.Format($"Student {StudentName} has been selected for next Round of Interview !!!");
            }
            else
            {
                return string.Format($"Student {StudentName} has been rejected for next Round of Interview !!!");
            }

        }*/

        public void InterviewCities(params string[] cities)
        {
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
