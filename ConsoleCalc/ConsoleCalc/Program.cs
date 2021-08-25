using System;
using System.Collections.Generic;

namespace ConsoleCalc
{
    class Program
    {

        static void Main(string[] args)
        {
            //Blocking code to establish the method for value input for the calculator
            int num1 = 0;
            int num2 = 0;
            string[] operand = {"A", "S", "M", "D"};


                Console.WriteLine("Welcome to the Console Calculator\n Please enter your first number:");
                num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 = Int)
                {
                    Console.WriteLine("Please enter your second number");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }

                else
                {
                    Console.WriteLine("You did not enter a number, please enter a number");
                    Console.ReadLine();
                }
                //Blocking code to run operand check to perform calculation and output result
                Console.WriteLine("Please enter your operand");
                Console.WriteLine("Add for Addition");
                Console.WriteLine("Sub for Subtraction");
                Console.WriteLine("Mul for Multiply");
                Console.WriteLine("Div for Divide");
                Console.ReadLine();
                switch(operand)
                {
                case A:
                    num1 += num2;
                case S:
                    num1 -= num2;
                case M:
                    num1 *= num2;
                case D:
                    num1 /= num2;
                    

            
            
                }
                Console.WriteLine($"Your result is {input[2]}");

           
        }
           
    }
}
