using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a string you want reversed!");
            string stringThatNeedsReversing = Console.ReadLine();
            string reversedString = ReversingString(stringThatNeedsReversing);
            Console.WriteLine(reversedString);
        }
        static string ReversingString(string newString)
        {
            char[] chr = new char[newString.Length];
            string reversedString;
            for (int i = 0; i < newString.Length; i++)
            {
                chr[i] = newString[i];
            }
            Array.Reverse(chr);
            reversedString = String.Join(",", chr);
            return reversedString;
        }
    }
}
