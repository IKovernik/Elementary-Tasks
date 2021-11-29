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
            int n=0;
            bool check = true;
            do
            {
                try
                {
                    Console.WriteLine("Input length 'n'");
                    n = int.Parse(Console.ReadLine());
                    check = false;                    
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
            //if (n<0 || n>1000000)
            //{
            //    Console.WriteLine("N must be integer, less than 1 000 000");
            //}
            

            } while (check);
            return n;

        }
        public int InputM()
        {
            int m = 0;
            bool check = true;
            do
            {
                try
                {
                    Console.WriteLine("input num 'm'");
                    m = int.Parse(Console.ReadLine());
                    check = false;
                }
                catch(Exception ex)
                {Console.WriteLine(ex.Message);}
            }
            while (check);
            return m;
        }
    }
}
