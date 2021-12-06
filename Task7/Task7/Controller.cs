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
        SequenceList SequenceList = new SequenceList();

        
        public void Run()
        {
            Console.WriteLine("Inputing length of sequence 'n'...");
            SequenceList.N = inputParametrs.InputNumber();

            Console.WriteLine("Input parametr 'm'...");
            SequenceList.M = inputParametrs.InputNumber();


            
            
            Console.WriteLine(string.Join(",", SequenceList.GetSequence(SequenceList.M,SequenceList.N)));
        }
}
}
