using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            const string oldstring = "Sun Rises in the West";
            Console.WriteLine("Sentence Before Replacing : {0} ", oldstring);
            string newString = oldstring.Replace("West", "East");
            Console.WriteLine("Sentence After Replacing : {0} ", newString);
            Console.ReadLine();
        }
    }
}
