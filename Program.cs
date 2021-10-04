using System;

namespace dotnetCoreConsole1
{
    //Difference between readonly and const keyword in C#
    class Program
    {
        // Constant fields
        //Const is a compile time constant.
        //const field can not be changed.
        //It can be declared inside the method.
        //In const fields, we can only assign values in declaration part.
        //It cannot be used with static modifiers
        public const int myvar = 10;
        public const string str = "Mohamed";

        // readonly variables
        //ReadOnly is a runtime constant 
        //Readonly The value of readonly field can be changed The value of the 
        //It cannot be declared inside the method.	
        //In readonly fields, we can assign values in declaration and in the constructor part.	
        //Readonly It can be used with static modifiers.
        public readonly int myvar1;
        public readonly int myvar2;
        public Program(int b, int c)
        {
    
            myvar1 = b;
            myvar2 = c;
            Console.WriteLine("Display value of myvar1 {0}, "+"and myvar2 {1}", myvar1, myvar2);
        }
        // Values of the readonly
        // variables are assigned
        // Using constructor
        static void Main(string[] args)
        {
             // Display the value of Constant fields
             Console.WriteLine("The value of myvar: {0}", myvar);
             Console.WriteLine("The value of str: {0}", str);
             //Display the value of Readonly fields
             Program obj1 = new Program(100, 200);
        }
    }
}
