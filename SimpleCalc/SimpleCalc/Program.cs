﻿using System;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //introduces program to user and asks for first number.
            Console.WriteLine("Let's perform a simple calculation between two numbers. ");
            Console.Write("Please enter the first number: ");

            //turn first number into double 
            string firstNumber = Console.ReadLine();
            double first = double.Parse(firstNumber);

            //ask for second number and turn it into double
            Console.Write("Please enter the second number: ");
            string secondNumber = Console.ReadLine();
            double second = double.Parse(secondNumber);

            //asks user for calculation method
            Console.Write("Would you like to add, subtract, multiply, or divide? ");
            string operation = Console.ReadLine();
            double answer = 0;

            //operation possibilites
            if (operation == "add")
            {
                answer = first + second;
                Console.WriteLine($"{first} + {second} = {answer}");
            }

            else if (operation == "subtract")
            {
                answer = first - second;
                Console.WriteLine($"{first} - {second} = {answer}");
            }

            else if (operation == "multiply")
            {
                answer = first * second;
                Console.WriteLine($"{first} x {second} = {answer}");
            }

            else if (operation == "divide")
            {
                answer = first / second;
                Console.WriteLine($"{first} / {second} = {answer}");
            }

            else
            {
                Console.WriteLine("There was a problem. Please enter add, subtract, multiply, or divide.");

            }

            //allows user to see the answer
            Console.WriteLine($"The answer is: {answer}");
            Console.ReadLine();



        }
    }
}
