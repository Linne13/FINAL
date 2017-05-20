using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);


            for (int i = 2; i < a * a; i++)
            {
                if (a % i == 1)
                {
                    Console.Write(" prime");
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("not Prime");
                    Console.ReadKey();
                }

            }
        }
    }
}
