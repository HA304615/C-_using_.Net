using System;

namespace InternalAccessSpecifier
{
    class FirstClass
    {
        internal void Message()
        {
            Console.WriteLine("Hello, from internal method!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FirstClass message = new FirstClass();
            message.Message();
        }
    }
}
