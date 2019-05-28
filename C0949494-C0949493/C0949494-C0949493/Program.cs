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
            AA beachball = new AA();
            beachball.Run();
        }
    }

    class Dog
    {
        // Data Attribute
        public string name;

        // Objects have BEHAVIORS called METHODs!
        public void Bark()
        {
            Console.WriteLine("Hello I am a Dog, My name is {0} ", name);
        }

        // Methods may take Parameters as input
        public void Bark(int age)
        {
            Console.WriteLine("Hello I am a Dog, I am {0} years old", age);
        }
    }

    class AA
    {
        public void Run()
        {
            string name;
            // Write a C# program to input your name and print Hello and your name in a separate line.
            Console.WriteLine("What is your Name?");
            name = Console.ReadLine();
            Console.WriteLine("HELLO! {0} ", name);
        }
    }
}
