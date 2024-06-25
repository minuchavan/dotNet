using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfowayInterviewApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student = new Student();
                student.StudentId = 1;
                student.StudentName= "Test";
                student.StudentEmail = "abc@gmail.com";
                student.StudentPhone= "1234567890";
                student.TotalMarks = 95;
                string result=student.calculateResult(student.TotalMarks);
                Console.WriteLine(result);
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
