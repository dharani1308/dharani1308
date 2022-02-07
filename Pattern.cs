using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assaignment_1
{
    class Pattern
    {
        static void Main(string[] args)
        {
            A m = new A();
            A.method();
            Console.ReadLine();
        }

    }
    class A
    {
        public static void method()
        { 
            Console.WriteLine("Enter the Number of Rows");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*" + " ");

                }
                Console.WriteLine();

            }
        }
    }
}

