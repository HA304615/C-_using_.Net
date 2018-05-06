using System;
using System.Collections;

namespace ListArraysHashTable
{
    class ListArrayHash
    {
        public void ListMethod()
        {
            Console.WriteLine("List Execution started");
            ArrayList arraylist = new ArrayList();
            arraylist.Add(1);
            arraylist.Add("Hello");
            arraylist.Add("Bye");
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
            arraylist.Remove(1);
            Console.WriteLine("1 has been removed from the list");
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arraylist.Contains("hello"));
            arraylist.Clear();

        }

        public void Arrays()
        {
            Console.WriteLine("Array execution started");
            int[] myArray = new int[5] { 1,2,3,4,5 };
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
            myArray[0] = 10;
            Console.WriteLine("After Replacing 1, array is:");
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }

        public void HashTables()
        {
            Hashtable emphash = new Hashtable();
            emphash.Add(1, "a");
            emphash.Add(2, "b");
            emphash.Add(3, "c");
            if(emphash.Contains("a"))
                Console.WriteLine("a already exists in the hash table!");
            ICollection values = emphash.Values; //Printing values
            Console.WriteLine("Hash Table Values are:");
            foreach (string item in values)
            {
                Console.WriteLine(item);
            }
            emphash.Remove(3);
            Console.WriteLine("c has been removed!");
            ICollection keys = emphash.Keys;
            Console.WriteLine("Hash Table Keys are:");
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }
            emphash.Clear();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListArrayHash listArrayHash = new ListArrayHash();
            listArrayHash.ListMethod();
            listArrayHash.Arrays();
            listArrayHash.HashTables();
        }
    }
}
