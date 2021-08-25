using System;
using System.Collections.Generic;

namespace ConsoleCalc
{
    class Program
    {

        static void Main(string[] args)
        {

            int num1 = 0;
            int num2 = 0;
            Int32 result;

            if (Int32.TryParse(Console.ReadLine(), out result))
            {
                


                Console.WriteLine("Welcome to the Console Calculator\n Please enter your first number:");
                num1 = Convert.ToInt32(Console.ReadLine(), result);



                Console.WriteLine($"{result} is not a number, please enter a number");



                Console.WriteLine("Please enter your second number");
                num2 = Convert.ToInt32(Console.ReadLine(), result);



                Int32.TryParse(Console.ReadLine(), out result);
                Console.WriteLine($"{result} is not a number, please enter a number");
            }






                Console.WriteLine("Please enter your operand");
                Console.WriteLine("Add for Addition");
                Console.WriteLine("Sub for Subtraction");
                Console.WriteLine("Mul for Multiply");
                Console.WriteLine("Div for Divide");

                switch (Console.ReadLine())
                {
                    case "Add":
                        Console.WriteLine($"Your result is {num1 + num2}");
                        break;
                    case "add":
                        Console.WriteLine($"Your result is {num1 + num2}");
                        break;
                    case "Sub":
                        Console.WriteLine($"Your result is {num1 - num2}");
                        break;
                    case "sub":
                        Console.WriteLine($"Your result is {num1 - num2}");
                        break;
                    case "Mul":
                        Console.WriteLine($"Your result is {num1 * num2}");
                        break;
                    case "mul":
                        Console.WriteLine($"Your result is {num1 * num2}");
                        break;
                    case "Div":
                        Console.WriteLine($"Your result is {num1 / num2}");
                        break;
                    case "div":
                        Console.WriteLine($"Your result is {num1 / num2}");
                        break;
                }



            
        }  
    }
}
