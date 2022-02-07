using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assaignment_1
{
    class SortingThreeNumbers
    {
        static void Main(string[] args)
        {
           
            Sorting();
            Console.Read();
        }

        static void Sorting()
        {
            Console.WriteLine("Enter Three Numbers");
            int i = Convert.ToInt32(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if (i<j && i<k)
            {
                Console.Write(i+",");
              if(j<k)
                {
                    Console.Write(j+","+k);
                }
              else
                {
                    Console.Write(k+","+j);
                }
            }
            else if(j<k && j<i)
            {
                Console.Write(j+",");
                if(k<i)
                {
                    Console.Write(k + "," + i);
                }
                else
                {
                    Console.Write(i+","+k);
                }

            }
            else
            {
                Console.Write(k+",");
                if(i<j)
                {
                    Console.Write(j+","+i);
                }
                else
                {
                    Console.Write(i+","+j);
                }
            }
             Console.WriteLine("\n Do you want to Continue? \n Y \n N");
            char c = Convert.ToChar(Console.ReadLine());
            if(c=='y'|| c== 'Y')
            {
                Sorting();
            }
             
            else if(c=='n'||c=='N')
            {
                Console.WriteLine("Thank you");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
               
            
        }
    }
}
