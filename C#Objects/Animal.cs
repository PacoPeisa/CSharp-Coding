using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Objects
{
    internal class Animal
    {
        //Inheritance
        public void MakeSound()
        {
            Console.WriteLine("Animal makes sound.");
        }

        //Polymorphism
        public virtual void Speak() // Virtual method
        {
            Console.WriteLine("Animal speaks");
        }
    }
}
