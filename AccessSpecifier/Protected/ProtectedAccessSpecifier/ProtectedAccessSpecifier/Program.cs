using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedAccessSpecifier
{
    class ClassOne
    {
        protected int _variable; //Protected Variable
    } 

    class ClassTwo:ClassOne
    {
        public ClassTwo()
        {
            this._variable = 1; //Accessible from its derived class
        }
    }

    class ClassThree
    {
        public ClassThree()
        {
            this._variable = 1; // Not Accessible from this class
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
