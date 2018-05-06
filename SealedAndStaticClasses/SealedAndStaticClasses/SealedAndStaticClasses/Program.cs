using System;

namespace SealedAndStaticClasses
{
    public static class TestClass
    {
        public static void WriteMethod()
        {
            Console.WriteLine("This method is called from static class!");
        }
    }

    sealed class CannotInherited
    {
        public  void TestMethod()
        {
            Console.WriteLine("Sealed Method");
        }
    }
    //class ChildClass:CannotInherited  ----not possible as its a sealed class


    class Program
    {
        static void Main(string[] args)
        {
            TestClass.WriteMethod();
        }
    }
}
