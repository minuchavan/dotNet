using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  string path = "C:\\Users\\Group011\\Desktop\\DotNet\\dotNet\\notice.dat";
              BinaryFormatter bf = new BinaryFormatter();
              using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
              {
                  Notice notice = new Notice() { NoticeID=1212,NoticeTitle=" ~~~~~ We have lecture on Sunday ~~~~~~ ",NoticeDate=DateTime.Now};
                  bf.Serialize(fs, notice);
                  fs.Close();
              }*/

            string path = "C:\\Users\\Group011\\Desktop\\DotNet\\dotNet\\notice.dat";
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
               Notice notice= bf.Deserialize(fs)as Notice;
                fs.Close();
                Console.WriteLine($"Notice id - {notice.NoticeID} \n  Notice title -{notice.NoticeTitle}\n Notice Date - {notice.NoticeDate}");
                Console.ReadKey();
            }
        }
    }
}
