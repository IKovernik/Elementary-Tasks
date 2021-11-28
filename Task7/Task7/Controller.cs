using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Controller
    {
        InputParametrs inputParametrs = new InputParametrs();
        StartNumber StartNumber = new StartNumber();

        public List<int> NumberSequence = new List <int>();
        public void Run()
        {
            int n = inputParametrs.InputN();
            int m = inputParametrs.InputM();


            int startint = StartNumber.FirstNumberOfRange(m);


            for (int i = startint; i < (startint + n); i++)
            {
                NumberSequence.Add(i);
               // Console.Write($"{i},");
            }

            Console.WriteLine(string.Join(",", NumberSequence));// в одну строку!!!
        }
}
}
