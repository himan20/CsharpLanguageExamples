using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInstanceConstructors
{
    class Program
    {
        public static void Main(string[] args)
        {
        }


        // Access modifiers are not allowed on static constructors
        //
        static Program()
        {

        }
    }
}