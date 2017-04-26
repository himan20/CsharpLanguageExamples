using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExperiments
{

    // Elements defined in a namespace cannot be defined as private, protected or protected internal
    // only public and internal are allowed here
    internal class Program
    {

        // For a valid entry point Main method, 
        // 1) it must be a static method, 
        // 2) it must be called Main, 
        // 3) it can have either no arguments or only 1 argument with type string[], 
        // 4) the return type of this method can only be either void or int
        // 5) All access modifiers are acceptable on the Main method
        protected static void Main(string[] args)
        {
        }


        // An application cannot have multiple Main methods with the same signature
        // for having another Main method, its signature must be different from the entry point method
        public int Main(string[] args) {
            return 0;
        }

        public void NotMain(string[] args) { }


        // The return type is not part of the method signature
        // Method signature includes : 
        // 1) Parameter types, their number and order
        // 2) The name of the method
        private int NotMain(string[] args) {
            return 0;
        }

        // A nested class within another class can have any access modifier
        protected internal class SubProgram
        {

        }
    }
}

namespace EncapsulationExperiments
{
    // We cannot have a class with the same name within the same namespace
    // if this class name was Program, it will result in the same fully-qualified name
    // which is not allowed
    public class AnotherProgram
    {

    }
}