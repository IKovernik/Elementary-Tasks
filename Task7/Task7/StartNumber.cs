using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class StartNumber 
    {
        public int FirstNumberOfRange(int m) 
                                              
        { 

        double start = Math.Sqrt(m); 
        start = Math.Ceiling(start); 
        int startint = (int)start;  
            return startint; 
          }  
    }

       
}
