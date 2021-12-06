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
            FibonacciNumbers newrange = new FibonacciNumbers();
            LengthInRange LengthInRange = new LengthInRange(); 



            Console.WriteLine("To generate sequence in diapason input '0' to sample by length input '1'");
            int choise = int.Parse(Console.ReadLine());


            if (choise == 0)
            {
                Console.Write("Enter start or range : ");
                int start = int.Parse(Console.ReadLine());


                Console.Write("Enter end of range  : ");
                int end = int.Parse(Console.ReadLine());

                newrange.GenerateInRange(start, end);

            }
            if (choise == 1)
            {
                Console.Write("Enter length of fibonacci sequence : ");

                int length = int.Parse(Console.ReadLine());

                int start = LengthInRange.StartEndSet(length).Item1;
                int end = LengthInRange.StartEndSet(length).Item2; //не вызываю ли я лишний раз StartEndSet?

                
                newrange.GenerateInRange(start, end);
            }
            //TODO add exeptions
        }
    }
}
