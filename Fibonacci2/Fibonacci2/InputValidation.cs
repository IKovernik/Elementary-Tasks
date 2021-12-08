using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci2
{
    public class InputValidation
    {

        private const int Maxvalue = 1000000;
        private const int Two = 2;
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

        public int InputChoise()
        {

            int choise = 0;
            bool check = true;
            do
            {
                try
                {
                    Console.WriteLine("Input value");
                    choise = int.Parse(Console.ReadLine());
                    check = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please, type ONLY numbers 0 or 1 without spaces and other symbols!");
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
                if (choise < 0 || choise > Two)
                {
                    Console.WriteLine("Value must be 0 or 1");
                    check = true;
                }


            } while (check);
            return choise;

        }
    }
}
