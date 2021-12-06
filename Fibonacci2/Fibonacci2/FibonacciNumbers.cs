using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci2
{
    public class FibonacciNumbers //был internal
    
    {
        public List<int> ListOfFibonacciNumbers = new List<int>();
        
        public List<int> GenerateInRange(int start, int end)
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

            Console.WriteLine(string.Join(" ", ListOfFibonacciNumbers)); 
                                   
            
            return ListOfFibonacciNumbers;
        }
    }

}
