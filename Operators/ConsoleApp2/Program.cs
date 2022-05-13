using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting num1 from the console.
            double num1 = double.Parse(Console.ReadLine());
            //Getting num2 from the console.
            double num2 = double.Parse(Console.ReadLine());
            //Getting the symbol from the console.
            string symbol = (Console.ReadLine());
            //If the symbol is + we do all the the actions in the brackets.
            if (symbol == "+")
            {
                double result = num1 + num2;
                //If the result is divides by 2 without residue the number is even.
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {symbol} {num2} = {result} - even");
                }
                //If the result divides by 2 with residue the number is odd.
                else
                {
                    Console.WriteLine($"{num1} {symbol} {num2} = {result} - odd");
                }
            }
            //If the symbol is - we do all the actions is the brackets.
            else if (symbol == "-")
            {
                //Result = num1 - num2
                double result = num1 - num2;
                //If the result is divides by 2 without residue the number is even.
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {symbol} {num2} = {result} - even");
                }
                //If the result divides by 2 with residue the number is odd.
                else
                {
                    Console.WriteLine($"{num1} {symbol} {num2} = {result} - odd");
                }
            }
            //If the symbol is * we do all the actions in thee brackets.
            if (symbol == "*")
            {
                //Result = num1 * num2
                double result = num1 * num2;
                //If the result is divides by 2 without residue the number is even.
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {symbol} {num2} = {result} - even");
                }
                //If the result divides by 2 with residue the number is odd.
                else
                {
                    Console.WriteLine($"{num1} {symbol} {num2} = {result} - odd");
                }
            }
            //If the symbol is / we do all the actions in the brackets.
            if (symbol == "/")
            {
                //If the second number is 0 we print "Cannot divide the first number by zero"
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    //Result = num1 / num2
                    double result = num1 / num2;
                    Console.WriteLine($"{num1} {symbol} {num2} = {result:f2}");

                }
            }
            //If the symbol is % we do all the actions in the brackets.
            if (symbol == "%")
            {
                if (num2 == 0)
                    {
                        //If the second number is zero we print "Cannot divide by zero"
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        //Result = num1 % num2
                        double result = num1 % num2;
                        //Result2 = num1 - result.
                        double result2 = num1 - result;
                        //result3 = num1 - result2
                        double result3 = num1 - result2;
                        Console.WriteLine($"{num1} {symbol} {num2} = {result3}");
                       
                    }
            }
        }
    }
}

        

    

