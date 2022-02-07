using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assaignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Temperature in Celsius");
            double Celsius = Convert.ToDouble(Console.ReadLine());
            double Kelvins = Celsius + 273;
            double Fahrenheit = Celsius * 18 / 10 + 32;
            Console.WriteLine(Celsius+" Celsius = "+Kelvins+"K");
            Console.WriteLine(Celsius+" Celsius = " +Fahrenheit+"F");
            Console.ReadLine();

        }
    }
}
