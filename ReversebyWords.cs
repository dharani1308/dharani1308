using System;

namespace Assaignment_1
{
    class ReversebyWords
    {
        static void Main()
        {
            reversebywords();
            Console.ReadLine();
        }
        static void reversebywords()
        {
            Console.WriteLine("Enter Your Sentence:");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
        }
    }   
}
