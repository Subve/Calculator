using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Give me your first number");
            int number1=int.Parse(Console.ReadLine());
            Console.WriteLine("Give me your second number");
            int number2=int.Parse(Console.ReadLine());
            Console.WriteLine("What do you want with them? +-*/%");
            char sign=Console.ReadKey().KeyChar;
            Console.WriteLine();
            string answ = $"{number1} {sign} {number2} = ";

            Console.WriteLine(answ);
            switch(sign)
            {
                case '+':
                    Console.WriteLine(number1+number2);
                    break;
                case '-':
                    Console.WriteLine(number1 - number2);
                    break;
                case '*':
                    Console.WriteLine(number1 * number2);
                    break;
                case '/':
                    Console.WriteLine(number1 / number2);
                    break;
                case '%':
                    Console.WriteLine(number1 % number2);
                    break;
                default :
                    Console.WriteLine("It's a wrong operator!");
                    break;
            }
                







        }
    }
}
