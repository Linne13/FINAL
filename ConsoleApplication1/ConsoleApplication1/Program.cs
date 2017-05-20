using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        public static bool Prime(int a)
        {
            for (int i = 2; i < a / 2; i++)
            {
                if (a % i == 2)
                {
                    return true;
                }
            }

            return false;
        }

        
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);
            if (Prime(a) == true)
            {
                Console.Write("Prime");
                Console.ReadKey();
            }

            if(Prime(a) == false)
            {
                Console.Write("NO");
                Console.ReadKey();
            }

           
        }
    }
}
