using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class InputParametrs
    {
        private const int Maxvalue = 1000000;
        public int InputNumber() 
        {
            
            int number = 0;
            bool check = true;
            do
            {
                try
                {
                    Console.WriteLine("Input value");
                    number = int.Parse(Console.ReadLine());
                    check = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please, type ONLY numbers without spaces and other symbols!");
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
                if (number < 0 || number > Maxvalue)
                {
                    Console.WriteLine("Value must be positive integer, less than 1 000 000");
                    check = true;
                }


            } while (check);
            return number;

        }
    }
}
