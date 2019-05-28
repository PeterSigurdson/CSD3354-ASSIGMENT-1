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
            AB beachball = new AB();
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

    class AB
    {
        public void Run()
        {
            int number1, number2;
            int mathOperation;
            Console.WriteLine("enter a number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What Math Operation would you like to do:    ");
            Console.WriteLine("Type 1 for ADD, 2 for Subtract, 3 for Multiply, 4 for Divide: ");

            mathOperation = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("the {0} of {1}, and {2}, is {3} ", "result", number1, number2, process(number1, number2));
        }

        public int process(int num1, int numb2)
        {
            return num1 - numb2;
        }

        public void SelectOperation(string whatDoesUserWantToDo)
        {
            switch (whatDoesUserWantToDo)
            {
                //case constant - expression1:
                //    statement(s);
                //    break;
                //case constant - expression2:
                //case constant - expression3:
                //    statement(s);
                //    break;

            }
        }
    }
    
     class IfThenExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("let's play a game - enter any number");
            int userInput = Convert.ToInt32(Console.ReadLine());
    
            if (userInput < 80) { Console.WriteLine("sorry you lose!");  }

            else if (userInput > 120) { Console.WriteLine("sorry you lose!");}
            
            else { 
            Console.WriteLine("YEAH!!! YOU WON!");}

        }
    public void TestStringEquality(){
            String Name = Console.ReadLine();
            String Name2 = Console.ReadLine();

            if (Name.Equals(Name2)) { Console.WriteLine("true"); }
            else { Console.WriteLine("true"); } 
        }
     
     }
    
    public void LargestNumber(){
     static void Main(string[] args)
        {
            int largest = 0;
            int num1, num2, num3;
      
            Console.WriteLine("enter 1st number: ");
             num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 3rd number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            {
                if (num1 > largest) { largest = num1; }
                if (num2 > largest) { largest = num2; }
                if (num3 > largest) { largest = num3; }

                Console.WriteLine(largest);
            }
        }   
    }
}
