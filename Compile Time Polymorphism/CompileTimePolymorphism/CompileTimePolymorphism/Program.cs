using System;

namespace CompileTimePolymorphism
{
    class Numbers
    {
        public int AddNumbers(int numOne, int numTwo) //Addnumbers Method with two parameters
        {
            return numOne + numTwo;
        }
        public int AddNumbers(int numOne, int numTwo, int NumThree)//Addnumbers Method with three parameters: Method overloading
        {
            return numOne + numTwo + NumThree;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            int result = numbers.AddNumbers(3, 4); //At compile time itself, compiler knows which AddNumbers method to call by parameters
            Console.WriteLine("Sum is: " + result);
        }
    }
}
