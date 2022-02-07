using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assaignment_1
{
    class isPrimeNumber
    {

       private static int num;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a Number");
            num = int.Parse(Console.ReadLine());
            IsPrime();
            
        }
        
        public static void IsPrime()
        {
          
            bool Isprime = true;
            for(int i =2;i<=num/2;i++)
            {
                if(num %i==0)
                {
                    Isprime = false;
                    Console.WriteLine(num + " is not prime number");
                    break;
                }
                if(Isprime)
                {
                    Console.WriteLine(num+" is prime number");
                    Console.ReadLine();
                }
                
            }
           
        }
    }
}
