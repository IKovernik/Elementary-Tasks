using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class SequenceList
    {
        public List<int> NumberSequence = new List<int>();
        public List<int> Create(int startint, int n)
        {
            for (int i = startint; i < (startint + n); i++)
            { NumberSequence.Add(i); }

            return NumberSequence;
        }
}
}
