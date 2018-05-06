using System;

namespace ExceptionHandling
{
    class Calculator
    {
        public void Division()
        {
            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed line");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception occured:{0}",ex);
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine("Result is {0}", div);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Division();

        }
    }
}
