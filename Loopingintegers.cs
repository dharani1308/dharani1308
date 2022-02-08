using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assaignment_1
{
    class Loopingintegers
    {
        static void Main()
        {
            loopingintegers();
        }
        static void loopingintegers()
        {
            bool checkvalue = true;
            List<string> madhu = new List<string>();
            do
            {
                Console.WriteLine("Enter the correct value:");
                madhu.Add(Console.ReadLine());
                Console.WriteLine("Enter if u want to continue press Yes or No");
                string answer = Console.ReadLine();
                checkvalue = answer == "Yes";
            } while (checkvalue);
            Console.WriteLine("The total count is :" + madhu.Count);
            List<string> nonint = new List<string>();
            List<int> inte = new List<int>();
            foreach (var element in madhu)
            {
                int no = 0;
                if (int.TryParse(element, out no))
                {
                    inte.Add(no);
                }
                else
                {
                    nonint.Add(element);
                }

            }
            Console.WriteLine("The number of integer values is count is " + inte.Count);
            Console.WriteLine("The number of noninteger values count is " + nonint.Count);
            Console.WriteLine("The sum of the all integer values is " + inte.Sum());
            Console.WriteLine("printing all integers:");
            foreach (int i in inte)
            {
                Console.WriteLine(i + "  ");
            }
            Console.Write("The non integer values is :");
            foreach (string s in nonint)
            {
                Console.Write(s + "  ");
            }
            Console.WriteLine("The total values is:");
            foreach (var i in madhu)
            {
                Console.Write(i + "  ");
            }
        }
    }
}


