using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0949494_C0949493
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's insert a DEBUG POINT");
            // how do we Create a Dog object?
            // we use the "new" keyword!
            Dog fido = new Dog();
            fido.name = "Fido";
        }
    }

    class Dog
    {
        // Data Attribute
        public string name;

        // Objects have BEHAVIORS!
        public void Bark()
        {
            Console.WriteLine("Hello I am a Dog, My name is {0} ", name);
        }
    }
}
