using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Task");
           
            FileInfo fi = new FileInfo("file1.txt");
            
            FileStream fs = new FileStream("file1.txt", FileMode.Open, FileAccess.Read);
           
            Console.Write(fs);
            Console.ReadKey();

            fs.Close();
        }
    }
}
