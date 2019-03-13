using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            if ((a == 1) ^ (b == 2))
            {
                Console.WriteLine("Verdadero");
            }
            else
            {
                Console.WriteLine("Falso");
            }
            Console.ReadKey();
        }
    }
}
