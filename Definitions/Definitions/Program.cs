using System;

namespace Definitions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
            If you want to make an action happen in C#, you must write a statement.
            A statement can be a line or block of code, and must end with a ;
            The following statement assigns the value "Winnie" to the string variable, dog,
            in order for it to be used later. 
            */

            string dog = "Winnie";
            

            /* 
            Expressions are lines of code which consist of operators and operands. 
            Expressions can evaluate values and invoke methods, among other things.
            Let's take a look at the second line below:
            This expression invokes the WriteLine method, which prints a message that combines the  
            variables {dog} and {age}.
            */

            int age = 2;
            Console.WriteLine($"My dog {dog} is {age} years old. ");


            /*
            An operator is a part of an expression that calls for an action to take place.
            In the following expression, the operators are int, =, +, and ;
            The int initializes b as an integer variable. 
            The = is an assignment operator, it assigns age + 1 to b;
            The + is an operator which adds age to 1.
            The ; dennotes the end of the line of code. 
            */
            
             int b = age + 1;


            /*
            An operand is the object of the operator's action.
            The first expression below assigns the operand birthday to a string. 
            The concatenation operator, +, connects the operands dog, b, and the words in " " . 
     
            In the second and third expressions, the operand is the class Console. 
            The operator () invokes the WriteLine and ReadLine methods.   
            */

            string birthday = "Next year " + dog + " will be " + b + " years old. ";
            Console.WriteLine(birthday);
            Console.ReadLine();
           


        }
    }
}
