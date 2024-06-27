using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfowayINOUTRefparam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student = new Student();
                student.StudentId = 1;
                student.StudentName = "Test";
                student.StudentEmail = "abc@gmail.com";
                student.StudentPhone = "1234567890";
                student.TotalMarks = 95;
                string company;      // for Out param
                string result = student.calculateResult(student.TotalMarks, out company);
               // string company="Capgemini";
               // string result = student.calculateResult(student.TotalMarks, ref company);
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
    }
}
