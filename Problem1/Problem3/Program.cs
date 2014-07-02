using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("I = : " + i);
                int int3 = i % 3;
                int int5 = i % 5;
                if (int3 == 0 && int5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (int3 == 0)
                    Console.WriteLine("Fizz");
                else if (int5 == 0)
                    Console.WriteLine("Buzz");
            }

                Console.ReadKey();
           
        }
    }
}
