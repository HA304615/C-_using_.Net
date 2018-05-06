using System;

namespace PublicAccessSpecifier
{
    class PublicClass
    {
        public void PublicMethod() //Public Method: Accessible from other class
        {
            Console.WriteLine("This is a public method called from a class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PublicClass pubClass = new PublicClass();
            pubClass.PublicMethod(); //Accessing public method
        }
    }
}
