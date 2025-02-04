using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Objects
{
    internal class Dog : Animal
    {
        // Inheritance
        public void Bark()
        {
            Console.WriteLine("Dog barks.");
        }

        // Dynamic polymorphism
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }
}
