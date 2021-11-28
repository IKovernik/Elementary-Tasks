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
            LengthInRange LengthInRange = new LengthInRange(); //правильно ли так делать?



            Console.WriteLine("Для вывода чисел по диапазону введите '0' для вывода по длине '1'");
            int choise = int.Parse(Console.ReadLine());


            if (choise == 0)
            {
                Console.Write("Введите начало диапазона : ");
                int start = int.Parse(Console.ReadLine());


                Console.Write("Введите конец диапазона  : ");
                int end = int.Parse(Console.ReadLine());

                newrange.GenerateInRange(start, end);

            }
            if (choise == 1)
            {
                Console.Write("Введите длину чисел фибо : ");

                int length = int.Parse(Console.ReadLine());

                int start = LengthInRange.StartEndSet(length).Item1;
                int end = LengthInRange.StartEndSet(length).Item2; //не вызываю ли я лишний раз StartEndSet?

                //int start = (int)Math.Pow(10, (length - 1));
                //if (start == 1) { start--; }
                //int end = (int)Math.Pow(10, length);

                newrange.GenerateInRange(start, end);
            }
        }
    }
}
