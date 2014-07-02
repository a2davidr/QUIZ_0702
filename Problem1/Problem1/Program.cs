using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {

            int result = compareint(2, 4);

            Console.WriteLine("lowest number " + result);
            Console.ReadKey();
        }


        static int compareint(int first, int second)
        {
            if (first < second)
                return first;
            else
                return second;
        }

    }
}
