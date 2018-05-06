using System;

namespace AbstractClasses
{
    abstract class Maths
    {
        public abstract int AddNumbers(int numOne, int numTwo);//absract method
    }

    class Numbers:Maths
    {
        public override int AddNumbers(int numOne, int numTwo) //Implement abstract method in derived class using override keyword
        {
            return numOne + numTwo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Numbers Num = new Numbers();
            int result = Num.AddNumbers(3, 4);
            Console.WriteLine("The sum is : "+ result);
        }
    }
}
