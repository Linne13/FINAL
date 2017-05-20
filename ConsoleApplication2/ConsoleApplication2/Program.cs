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
            di.GetFiles();
            di.GetType();

            Console.Write(di.GetType());
            Console.ReadKey();
        }
    }
}
