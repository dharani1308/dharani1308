using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assaignment_1
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(x + " * " + i + " = " + i * x);
                i++;
            }
        }

    }
}
