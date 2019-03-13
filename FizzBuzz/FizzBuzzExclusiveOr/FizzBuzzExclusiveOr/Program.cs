using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzExclusiveOr
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num < 100; num++)
            {
                if ((num % 3 == 0) ^ (num % 5 == 0))
                {
                    if (num % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (num % 5 == 0){
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                }
                else
                {
                    Console.WriteLine(num);
                }
                Console.WriteLine();
            }
        }
    }
}
