using System;

namespace UsageOfIntefaces
{
    interface Shape
    {
        void Draw();//Method without implementation
    }
    public class Rectangle:Shape
    {
        public void Draw()
        {
            Console.WriteLine("This is the method of drawing rectangle.");//Implementation of method in its derived class
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Draw();
        }
    }
}
