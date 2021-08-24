using System;
using System.Collections.Generic;

namespace ConsoleCalc
{
    class Program
    {
        public static int Int { get; private set; }

        static void Main(string[] args)
        {

            int[] input = new int[4]; //Number storage for calculator function

            Console.WriteLine("Welcome to the Console Calculator\n Please enter your first number:");
            Console.ReadLine();
            if (input[0] == Int)
            {
                Console.WriteLine("Please enter your second number");
                Console.ReadLine();
            }
                         
            else
            {
                Console.WriteLine("You did not enter a number, please enter a number");
                Console.ReadLine();
            }

            Console.Writeline("Please enter your operand(+, -, * or /)");
            Console.ReadLine();
            if (input[2]= '+')
                {
                input[0] += input[1]
                    }
                    if (input[2] = '-')
                    input[0] -= input[1];
            if (input[2] = '*')
                input[0] *= input[1];
            if (input[2] = '/')
                input[0] /= input[1];
            Console.WriteLine($"Your result is {input[3]}");


        }
           
    }
}
