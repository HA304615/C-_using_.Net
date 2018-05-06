using System;

namespace FlowControlConditionalStatements
{
    class statements
    {
        public void SwitchStatement()
        {
            Console.WriteLine("Switch Statement started!");
            int input;
            Console.Write("Enter a character");
            input = Convert.ToInt32(Console.ReadLine());
            //Switch 
            switch (input)
            {
                case 1:
                    Console.WriteLine("Hi, you have entered 1");
                    break;
                case 2:
                    Console.WriteLine("Hi, you have entered 2");
                    break;
                default:
                    Console.WriteLine("You have not entered 1 or 2");
                    break;
            }
        }
        public void IfElseStatement()
        {
            Console.WriteLine("If else statement started!");
            int input;
            Console.Write("Enter a character");
            input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("You have entered 1");
            }
            else
            {
                Console.WriteLine("You have entered a number except one");
            }
        }
        public void WhileLoop()
        {
            Console.WriteLine("While Loop Started!");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        public void DoWhile()
        {
            Console.WriteLine("Do while loop started!");
            int input = 1;
            do
            {
                Console.WriteLine(input);
                input++;
            } while (input < 5);
        }
        public void ForLoop()
        {
            Console.WriteLine("For Loop started!");
            for(int k=1;k<3; k++)
            {
                Console.WriteLine(k);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            statements statement = new statements();
            statement.SwitchStatement();
            statement.IfElseStatement();
            statement.WhileLoop();
            statement.DoWhile();
            statement.ForLoop();
        }
    }
}
