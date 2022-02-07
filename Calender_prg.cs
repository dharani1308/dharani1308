using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assaignment_1
{
    class Calender_prg

    {
        static void Main()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter the valid Month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the valid year");
            int year = int.Parse(Console.ReadLine());
            Cldr(month,year);
            Console.WriteLine(".....................");
            Console.WriteLine();
        }
        public static void Cldr(int month, int year)
        {
            if (year > 0 && year % 4 == 0 && month == 2)
            {
                Console.WriteLine(" S  M  T  W  T  F  S");
                Console.WriteLine("          1  2  3  4");
                Console.WriteLine(" 5  6  7  8  9  10 11");
                Console.WriteLine(" 12 13 14 15 16 17 18");
                Console.WriteLine(" 19 20 21 22 23 24 25");
                Console.WriteLine(" 26 27 28 29         ");

            }
            else if (year > 0 && month == 2)
            {
                Console.WriteLine(" S  M  T  W  T  F  S");
                Console.WriteLine("          1  2  3  4");
                Console.WriteLine(" 5  6  7  8  9  10 11");
                Console.WriteLine(" 12 13 14 15 16 17 18");
                Console.WriteLine(" 19 20 21 22 23 24 25");
                Console.WriteLine(" 26 27 28            ");

            }
            else if (year > 0)
            {
                if (month >= 1 && month <= 12)
                {
                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                    {
                        Console.WriteLine(" S  M  T  W  T  F  S");
                        Console.WriteLine("          1  2  3  4");
                        Console.WriteLine(" 5  6  7  8  9  10 11");
                        Console.WriteLine(" 12 13 14 15 16 17 18");
                        Console.WriteLine(" 19 20 21 22 23 24 25");
                        Console.WriteLine(" 26 27 28 29 30 31   ");
                    }
                    else
                    {
                        Console.WriteLine(" S  M  T  W  T  F  S");
                        Console.WriteLine("          1  2  3  4");
                        Console.WriteLine(" 5  6  7  8  9  10 11");
                        Console.WriteLine(" 12 13 14 15 16 17 18");
                        Console.WriteLine(" 19 20 21 22 23 24 25");
                        Console.WriteLine(" 26 27 28 29 30      ");

                    }
                }
            }
            else
            {
                Console.WriteLine("Enter a valid Month and Year");
            }  
        }
    }
}




