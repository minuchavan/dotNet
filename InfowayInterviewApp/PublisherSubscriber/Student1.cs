using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber
{
    public delegate void InterviewBasket();
    internal class Student1
    {
        //Actions/Events
        public event InterviewBasket Onselection;

        public event InterviewBasket Onrejection;
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhone { get; set; }
        public int TotalMarks { get; set; }

        public string calculateResult(int TotalMarks, ref string companyName)
        {


            if (TotalMarks > 80)
            {
                if (Onselection!=null)
                {
                    Onselection();
                }
                return string.Format($"Student {StudentName} has been selected for next Round of Interview !!!");
            }
            else
            {
                if (Onrejection!=null)
                {
                    Onrejection(); 
                }
                return string.Format($"Student {StudentName} has been rejected for next Round of Interview !!!");
            }

        }

        public void InterviewCities(params string[] cities)
        {
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
