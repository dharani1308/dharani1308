using System;

namespace Assaignment_1
{
    class SumOfPositiveAndNeg
    {
        static void Main(string[] args)
        {
            AverageValues();
            Console.ReadLine();
        }

       static void AverageValues()
        {
            Console.WriteLine("Enter the 10 real numbers ");

            int[] arr = new int[10];
            int Sum_of_Positive = 0;
            int Sum_of_Negative = 0;
            int Count_of_Postive = 0;
            int Count_of_Negative = 0;
            for(int i =0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                
            }
            for(int i=0; i<arr.Length;i++)
            {
                if(arr[i] >= 0)
                {
                    Sum_of_Positive = Sum_of_Positive + arr[i];
                    Count_of_Postive++;
                }
                else
                {
                    Sum_of_Negative = Sum_of_Negative + arr[i];
                    Count_of_Negative++;
                }
            }
            float Avrg_of_Positive = Sum_of_Positive / Count_of_Postive;
            float Avrg_Of_Negative = Sum_of_Negative / Count_of_Negative;
            Console.WriteLine("Average of Positive numbers = " +Avrg_of_Positive);
            Console.WriteLine("Average of Negative numbers = "+Avrg_Of_Negative);
            
        }
    }
}
