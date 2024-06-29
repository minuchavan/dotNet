using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowesConsoleExplororAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                //  Console.WriteLine($"{drive.Name}");       it prints all the drive name with network drive also

                try
                {
                    if (drive.DriveType != DriveType.Unknown)
                    {
                       // Console.WriteLine($"{drive.Name}");   //c
                        /* Console.WriteLine($"{drive.DriveType}"); //fixed
                         Console.WriteLine($"{drive.TotalFreeSpace}"); //142606200832
                         Console.WriteLine($"{drive.TotalSize}");       //239376830464
                         Console.WriteLine($"{drive.AvailableFreeSpace}"); */ //142606200832
                        var drivename = drive.Name;
                        DirectoryInfo directoryInfo = new DirectoryInfo(drivename);
                        foreach (DirectoryInfo directoryInfo1 in directoryInfo.GetDirectories())
                        {

                           // Console.WriteLine($"\t {directoryInfo1.Name}");
                            foreach (FileInfo fileInfo2 in directoryInfo1.GetFiles())
                            {
                                if (fileInfo2.Extension == ".txt")
                                {
                                    Console.WriteLine($"\t{fileInfo2.Name}");
                                }

                               // Console.WriteLine($"\t\t{fileInfo2.Name}");
                            }
                        }

                    }

                }
                catch (UnauthorizedAccessException uae)
                {

                    Console.WriteLine(uae.Message);
                }
                catch (DirectoryNotFoundException dnfe)
                {
                    Console.WriteLine(dnfe.Message);
                }
            }
            Console.ReadKey();

        }
    }
}
