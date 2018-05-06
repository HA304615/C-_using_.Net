using System;

namespace Constructor
{
    class ConstructorClass
    {
        string name;
        int id;
        double salary;
        public ConstructorClass() //Default Constuctor
        {
            Console.WriteLine("Hi, Default Constructor is called!");
        }
        public ConstructorClass(string Name, int Id, double Salary)//Parameterized constructor
        {
            this.name = Name;
            this.id = Id;
            this.salary = Salary;
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Id:" + Id);
            Console.WriteLine("Salary:" + Salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConstructorClass constclass = new ConstructorClass();
            ConstructorClass paraconstruct = new ConstructorClass("ABC", 123456, 10000);
        }
    }
}
