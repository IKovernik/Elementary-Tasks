using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInWords
{
    public class InputFormatValidate
    {
         
        private const long Maxvalue = 999999999;
        public string InputNumber()
        {
            string format = "000 000 000";
            long number = 0;
            string stringNumber;
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
                    Console.WriteLine("Value must be positive integer, less than 999999");
                    check = true;
                }


            } while (check);

            stringNumber = number.ToString(format); 
            return stringNumber;

        }
    }
}
