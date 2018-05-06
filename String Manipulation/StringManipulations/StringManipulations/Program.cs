using System;
using System.Linq;

namespace StringManipulations
{
    class Program
    {
       
        static bool again = true;

        static void Main(string[] args)
        {
            while (again)
            {
                Console.Write("Enter a string:" + " ");
                var inputString = Console.ReadLine().ToString();
                var length = inputString.Length;
                if (length < 5)
                {
                    try
                    {
                        Console.WriteLine("Please Enter a string of min 5 characters!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    var leftSubstring = inputString.Substring(0, 5).ToList();
                    var rightSubstring = inputString.Substring(length - 5).ToList();
                    var middleChars = inputString.Substring(4, 5).ToList();
                    Console.WriteLine("First five left Characters of string are:");
                    foreach (char c in leftSubstring)//Print of first five left characters
                    {
                        Console.WriteLine(c);
                    }
                    Console.WriteLine("First five right Characters of string are:");
                    foreach (char c in rightSubstring)//Print of last five left characters
                    {
                        Console.WriteLine(c);
                    }
                    Console.WriteLine("Middle five  Characters of string are:");
                    foreach (char c in middleChars)//Print of middle left characters
                    {
                        Console.WriteLine(c);
                    }

                }
            }
        }
    }
}
