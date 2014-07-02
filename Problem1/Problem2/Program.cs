using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book BookA = new Book() { Price = 10.99M };
            Book BookB = new Book() { Price = 19.95M };

            int returnValue = 0;
            
            if (BookA.Price > BookB.Price)
                returnValue = -1;
            else if (BookA.Price < BookB.Price)
                returnValue = 1;
            else
                returnValue = 0;

            Console.WriteLine("Return value is: " + returnValue);
            Console.ReadKey();
        }
    }
}
