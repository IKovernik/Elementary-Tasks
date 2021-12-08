using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci2
{
    public class FibonacciNumbers
    {
        public int Start { get; set; }
        public int End { get; set; } 
        public int Length { get; set; }
    
    
        public List<int> ListOfFibonacciNumbers = new List<int>();

        public Tuple<int, int> StartEndSet(int length)
        {

            int start = (int)Math.Pow(10, length - 1);
            if (start == 1) { start--; }
            int end = (int)Math.Pow(10, length);

            return Tuple.Create<int, int>(start, end);
        }

        public List<int> GenerateInRange(int start, int end)
        {
            
            if (start == 0)

            {
                ListOfFibonacciNumbers.Add(0); 
            }
            
            int j = 1;
            for (int i = 1; i <= end; i += j)
            {
                if (i >= start)
                {
                    ListOfFibonacciNumbers.Add(i);
                }
                j = i - j;

            }
                                   
            
            return ListOfFibonacciNumbers;
        }
    }

}
