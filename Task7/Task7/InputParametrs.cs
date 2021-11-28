using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class InputParametrs
    {
        public int InputN()
        {
            Console.WriteLine("Input length 'n'");
            int n = int.Parse(Console.ReadLine());
            return n;
        
         }
        public int InputM()
        {
            Console.WriteLine("input num 'm'");
            int m = int.Parse(Console.ReadLine());
            return m;
        }
    }
}
