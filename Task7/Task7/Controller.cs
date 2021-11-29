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
        SequenceList SequenceList = new SequenceList();

        //public List<int> NumberSequence = new List <int>();
        public void Run()
        {
            int n = inputParametrs.InputN();
            int m = inputParametrs.InputM();


            int startint = StartNumber.FirstNumberOfRange(m);

            List <int> NumberSequence = SequenceList.Create(startint,n); //нормально ли, что коллекция называется так же как и в классе SequenceList? 
            
            Console.WriteLine(string.Join(",", NumberSequence));// в одну строку!!!
        }
}
}
