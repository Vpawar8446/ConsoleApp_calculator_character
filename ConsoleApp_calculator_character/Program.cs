using System;

namespace ConsoleApp_calculator_character
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, res,ch;
            Console.WriteLine("=============== Calculator Menu ===============");
            Console.Write("Enter the first number : ");
            //num1 = Convert.ToChar(Console.ReadLine());
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            //num2 = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter the character : ");
            ch = Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case '+':
                    res = num1 + num2;
                    Console.WriteLine(" Addition of {0} + {1} = {2}", num1,num2,res);
                    break;
                case '-':
                    res = num1 - num2;
                    Console.WriteLine("Substraction of {0} + {1} = {2}", num1, num2, res);
                    break;
                case '*':
                    res = num1 * num2;
                    Console.WriteLine("Multiplication of {0} + {1} = {2}", num1, num2, res);
                    break;
                case '/':
                    res = num1 / num2;
                    Console.WriteLine("Division(Quotient) of {0} + {1} = {2}", num1, num2, res);
                    break;
                case '%':
                    res = num1 % num2;
                    Console.WriteLine("Modulus(Remainder) of {0} + {1} = {2}", num1, num2, res);
                    break;

                default:
                    Console.WriteLine("Incorrect Operation ");
                    break;


            }
            Console.WriteLine("==================================================");
        }
    }
}
