using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double x1, x2;
                string _operator;
                Console.WriteLine("Enter the first number");
                x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the operator");
                _operator = Console.ReadLine();
                Console.WriteLine("Enter the second number");
                x2 = Convert.ToDouble(Console.ReadLine());
                switch (_operator)
                
                {
                    case "+":
                        Console.WriteLine(x1 + x2);
                       break;
                       case "-":
                        Console.WriteLine(x1 - x2);
                        break;
                    case "/":
                        Console.WriteLine(x1 / x2);
                        break;
                    case "*":
                        Console.WriteLine(x1 * x2);
                        break;

                       }

            }

        }
    }
}
