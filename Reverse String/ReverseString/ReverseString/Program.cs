using System;


namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            
            string reverseString="";
            int length;
            Console.Write("Enter a string:"+ " ");
            inputString = Console.ReadLine();
            length = inputString.Length - 1;
            while(length >= 0)
            {
                reverseString = reverseString + inputString[length];
                length--;
            }
            Console.WriteLine("Before Reversing:" + inputString);
            Console.WriteLine("After Reversing:" + reverseString);
        }
    }
}
