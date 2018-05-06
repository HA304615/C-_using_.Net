using System.Text;
using System;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Hello, First employee");
            builder.AppendLine();
            builder.AppendLine("one more employee added");
            string builderStringOne = builder.ToString();
            Console.WriteLine(builderStringOne);
            builder.Replace("employee", "staff");
            string builderStringtwo = builder.ToString();
            Console.WriteLine(builderStringtwo);
            builder.Insert(builder.Length, 'h');
            string builderStringthree = builder.ToString();
            Console.WriteLine(builderStringthree);
        }
    }
}
