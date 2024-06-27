using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Group011\Desktop\DotNet\dotNet\logger.txt";
            /*
             if (!File.Exists(path))
            {
                File.Create(path);
            }
            File.WriteAllText(path, "Welcome to Group011 Of Infoway !!!!!!!!");
            */
            //It will Generate Exception 

            if (!File.Exists(path))
            {
                var fs=File.Create(path);
                fs.Close();
                fs.Dispose();
            }
            File.WriteAllText(path, "Welcome to Group011 Of Infoway !!!!!!!!\n");
            // File.WriteAllText(path, "DOTNET FileOperations Performance !!!!!!!!");   it willoverride prevoius text
            File.AppendAllText(path, "DOTNET FileOperations Performance !!!!!!!!\n");
            File.AppendAllText(path, "we create file by giving path on program... \n then we check if file is already created or not ..if not \n then we create" +
                "new txt file\n and then we write some thing on that..after command \n second writealltext  it will override the previous \n text for solving that issue " +
                "we use\n appendalltext and then all the string are\n save on file which we are created.. !!!!!!!!");
            Console.ReadKey();
        }
    }
}
