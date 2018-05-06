using System;

namespace ConditionalStatements
{
    class Program
    {
       
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Enter the number between 1 to 3");
                var inputValue = Convert.ToInt32(Console.ReadLine());
                if (inputValue == 1)
                {
                    Console.WriteLine("Value entered is 1");
                }
                else if (inputValue == 2)
                {
                    Console.WriteLine("Value entered is 2");
                }
                else if (inputValue == 3)
                {
                    Console.WriteLine("Value entered is 3");
                }
                else
                {
                    Console.WriteLine("Entered value does not lie between 1 to 3");
                }
            }
            
        }
    }
}
