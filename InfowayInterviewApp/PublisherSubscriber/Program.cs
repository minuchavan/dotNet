using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student1 student = new Student1();
                student.Onselection += new InterviewBasket(Oracledb);
                student.Onselection += new InterviewBasket(ExcelDb);
                student.Onrejection += new InterviewBasket(Mssqlserverdb);
                student.StudentId = 1;
                student.StudentName = "Test";
                student.StudentEmail = "abc@gmail.com";
                student.StudentPhone = "1234567890";
                student.TotalMarks = 55;
                if (student.TotalMarks > 80 && student.TotalMarks < 95)
                {
                    student.Onselection -= new InterviewBasket(ExcelDb);
                }
                //string company       for Out param
                // string result = student.calculateResult(student.TotalMarks, out company);
                string company = "Capgemini";
                string result = student.calculateResult(student.TotalMarks, ref company);
                Console.WriteLine($"interview for company - {company} ");
                Console.WriteLine(result);
                student.InterviewCities("Pune", "Banglore", "Nashik", "Mumbai");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            Console.ReadKey();
        }

        private static void Student_Onrejection()
        {
            throw new NotImplementedException();
        }

        private static void  Oracledb()
        {
            Console.WriteLine("Data stored in oracledb");

        }

        private static void Mssqlserverdb()
        {
            Console.WriteLine("Data stored in Microsoft sql server db");

        }
        private static void ExcelDb()
        {
            Console.WriteLine("Data is stored in Excel DB!");
        }
    }
}
