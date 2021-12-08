using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci2
{
    internal class Controller
    {
        public void Run()
        {
            FibonacciNumbers fibonacciNumbers = new FibonacciNumbers();
            InputValidation validation = new InputValidation();
            
            Console.WriteLine("To generate sequence in diapason input '0' to sample by length input '1'");
            int choise = validation.InputChoise();



            if (choise == 0)
            {
                Console.Write("Enter start or range : ");
                
                
                fibonacciNumbers.Start = validation.InputNumber();


                Console.Write("Enter end of range  : ");
                
                
                fibonacciNumbers.End = validation.InputNumber();
                Console.WriteLine(string.Join(" ", fibonacciNumbers.GenerateInRange(fibonacciNumbers.Start, fibonacciNumbers.End)));
                

            }
            if (choise == 1)
            {
                Console.Write("Enter length of fibonacci sequence : ");
                
                fibonacciNumbers.Length = validation.InputNumber();//<= 9

                (fibonacciNumbers.Start, fibonacciNumbers.End) = fibonacciNumbers.StartEndSet(fibonacciNumbers.Length);

                Console.WriteLine(string.Join(" ", fibonacciNumbers.GenerateInRange(fibonacciNumbers.Start,fibonacciNumbers.End)));
            }
            
        }
    }
}
