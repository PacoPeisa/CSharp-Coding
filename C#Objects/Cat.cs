using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Objects
{
    public class Cat
    {
        //field name
        private string name;
        //field color
        private string color;

        public string Name
        { 
            get { return this.name; }   set { this.name = value; }
        }

        public string Color
        {
            get { return this.color; }  set { this.color = value; }
        }

        //Default constructor
        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }

        //Constructor with parameters;
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void SayMeow()
        {
            Console.WriteLine("Cat {0} said : Meowwwwwww!", name);
        }
    }
}
