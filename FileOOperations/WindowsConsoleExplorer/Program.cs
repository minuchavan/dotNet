using System;
using System.IO;

namespace WindowsConsoleExplorer
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
                    if (drive.DriveType != DriveType.Network)
                    {
                        Console.WriteLine($"{drive.Name}");   //c
                        /* Console.WriteLine($"{drive.DriveType}"); //fixed
                         Console.WriteLine($"{drive.TotalFreeSpace}"); //142606200832
                         Console.WriteLine($"{drive.TotalSize}");       //239376830464
                         Console.WriteLine($"{drive.AvailableFreeSpace}"); */ //142606200832
                        var drivename = drive.Name;
                        DirectoryInfo directoryInfo = new DirectoryInfo(drivename);
                        foreach (DirectoryInfo directoryInfo1 in directoryInfo.GetDirectories())
                        {
                            Console.WriteLine($"\t {directoryInfo1.Name}");
                            foreach (FileInfo fileInfo2 in directoryInfo1.GetFiles())
                            {
                                
                                Console.WriteLine($"\t\t{fileInfo2.Name}");
                            }
                        }

                    }

                }
                catch (UnauthorizedAccessException uae)
                {

                    Console.WriteLine(uae.Message);
                }
                catch(DirectoryNotFoundException dnfe) 
                {
                    Console.WriteLine(dnfe.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
