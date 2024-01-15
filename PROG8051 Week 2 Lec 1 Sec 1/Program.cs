using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading from the Console
            Console.WriteLine("Please enter your name:");
            string readname = Console.ReadLine();
            Console.WriteLine("user name is " + readname);

            Console.WriteLine("Please enter your age:");
            string readage = Console.ReadLine();


            string output = $"The name of the user is {readname} and user is {readage} years old";

            Console.WriteLine(output);
            Console.WriteLine("user age is " + readage);
            // Conversion between data types

            int test_age = 24;
            // before conversion
            Console.WriteLine(test_age.GetType());
            // 1. convert int to string
            // after conversion
            Console.WriteLine(test_age.ToString().GetType());

            string test_code = "1234";

            // Convert to int
            // before
            Console.WriteLine(test_code.GetType());

            // after conversion
            Console.WriteLine(Convert.ToInt32(test_code).GetType());


            Console.WriteLine("convert double to int");
            double test_weight = 134.6;
            Console.WriteLine(Convert.ToInt32(test_weight));
            Console.WriteLine(Convert.ToInt32(test_weight).GetType());


            Console.WriteLine("convert int to double");
            int test_weight2 = 135;
            Console.WriteLine(Convert.ToDouble(test_weight2)+0.2);
            Console.WriteLine(Convert.ToDouble(test_weight2).GetType());


            // Working with integers
            int a = 5;
            int b = 6;
            Console.WriteLine(a + b);


            // Strings 

            string name = "Daniel";
            string lastname = "Meyer";
            int age = 25;
            // string concatenation
            Console.WriteLine(name + " " +lastname + " is " + age + " years old");

            // Interpolation
            string result = $"{name} {lastname} is {age} years old";
            Console.WriteLine(result);

            // How to access individual characters of the string
            string password = "Prateek_2000sajdgsafdkajs!";

            Console.WriteLine(password.Substring(3));

            // Length of a string

            Console.WriteLine(password.Length);

            // How to access to the second last character of the string

            Console.WriteLine(password[password.Length-2]); 

            // Variables
            // Constant using the keyword const

            // Data Types
            // 1. int / long
            // Declaration of a variable
            int age1 ;
            // Assign a value
            age1 = 24;

            // 2. double/float
            double weight = 155.5;

            
            // character - char
            char firstLetter = 'A';

            // string 
            string fname = "Ogechi";

            // boolean - True/False
            bool result1 =  true;


            Console.WriteLine(weight);

            weight = 154.2;

             Console.WriteLine(weight);
            // Console.writeline vs Consonle.Write

            Console.Write("Hello, World Again!");
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Hello, World!");
            Console.Write("Hello, World Again!");

            // Comments

            // Single line comment
            // Console.Write

            // multi line comment
           /* 
            Console.Write("Hello, World Again!");
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Hello, World!");
            Console.Write("Hello, World Again!");
           */




        }
    }
}
