
// example Hello World

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace first_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // below code will return namespace name. e.g: "Namespace: first_project"
            string name = typeof(Program).Namespace ?? "None!";
            Console.WriteLine($"Namespace: {name}");


            /*
             "throw new Exception(); ", 
             The output in the console window will show the result of running your application, 
             including that a hidden "Program" class was defined by the compiler 
             with a method named " <Main>$ " that has a parameter named args for passing in arguments.
             */
            throw new Exception();

            
        }
    }
}