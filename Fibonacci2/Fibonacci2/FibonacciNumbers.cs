using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci2
{
    public class FibonacciNumbers //был internal
    
    {
        public List<int> ListOfFibonacciNumbers = new List<int>();//создаем коллекцию для хранения чисел фибоначчи
        
        public List<int> GenerateInRange(int start, int end) //выводит числа фибоначчи из заданного диапазона в коллекцию
        {
            
            if (start == 0) { ListOfFibonacciNumbers.Add(0); } 
            int j = 1;
            for (int i = 1; i <= end; i += j)
            {
                if (i >= start)
                {
                    ListOfFibonacciNumbers.Add((int)i);
                }
                j = i - j;

            }

            Console.WriteLine(string.Join(" ", ListOfFibonacciNumbers)); //вывод в одну строку!
                                   
            //Console.ReadKey();  надо не надо?
            return ListOfFibonacciNumbers;
        }
    }

}
