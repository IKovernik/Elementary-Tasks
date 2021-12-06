using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci2
{
    public class LengthInRange
       
    {
       
        public Tuple<int,int> StartEndSet(int length) 
        {
            
            int start = (int)Math.Pow(10, length - 1);
            if (start == 1) { start--; }
            int end = (int)Math.Pow(10, length);
           
                return Tuple.Create<int,int>(start,end);
        }
}
}
