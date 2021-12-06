using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class SequenceList
    {
        
        public int M { get; set; }
        public int N { get; set; }


        public List<int> NumberSequence = new List<int>();

        
        public List<int> GetSequence(int m, int n) //получение последовательности типа гет и тд
        {
            int startInt = (int)Math.Ceiling(Math.Sqrt(m));
            for (int i = startInt; i < (startInt + n); i++)
            {
                NumberSequence.Add(i);
            }

            return NumberSequence;
        }
}
}
